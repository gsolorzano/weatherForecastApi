# Create and start the Docker container
Write-Host "Creating and starting the MongoDB container..."
docker-compose up -d

# Wait for MongoDB to fully initialize (adjust time as needed)
Start-Sleep -Seconds 2

# Add mock data to MongoDB
Write-Host "Adding mock data into MongoDB..."
$mongoScript = @"
use WeatherForecast;

db.createCollection('Forecasts');

db.Forecasts.insertMany([
  {
    Date: new Date('2023-09-01T00:00:00Z'),
    TemperatureC: 25,
    Summary: 'Sunny'
  },
  {
    Date: new Date('2023-09-02T00:00:00Z'),
    TemperatureC: 28,
    Summary: 'Cloudy'
  },
  {
    Date: new Date('2023-09-03T00:00:00Z'),
    TemperatureC: 31,
    Summary: 'Rainy'
  }
]);
"@

# Check if we can write to the file
$filePath = "./init-mongo.js"

if (Test-Path $filePath) {
    Remove-Item -Path $filePath -Force
}

try {
    $mongoScript | Out-File -FilePath $filePath
}
catch {
    Write-Host "Failed to write to $filePath. Please check your permissions."
    exit 1
}

# Execute MongoDB script to add mock data
try {
    Get-Content $filePath | docker exec -i mongodb_weatherForecast /usr/bin/mongosh
}
catch {
    Write-Host "Failed to read from $filePath or execute the MongoDB script."
    exit 1
}

# Remove the temporary Mongo script
Remove-Item -Path $filePath -Force

Write-Host "Mock data added successfully."
