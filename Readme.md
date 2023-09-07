# Weather Forecast API

## Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Execution](#execution)
  - [Run Locally in Visual Studio](#run-locally-in-visual-studio)
  - [Run with Docker](#run-with-docker)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This is a basic .NET 7 API example using features like:

- Dependency Injection
- AutoMappers
- FluentValidations
- MongoDB
- Swagger

## Prerequisites

Make sure you have installed all of the following prerequisites on your development machine:

- .NET 7 SDK - [Download & Install .NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- Visual Studio 2022 or later - [Download & Install Visual Studio](https://visualstudio.microsoft.com/downloads/)
- Docker - [Download & Install Docker](https://www.docker.com/products/docker-desktop)

## Installation

Clone the repository:

```bash
git clone https://github.com/gsolorzano/weatherForecastApi
```

Navigate to the project directory:

\`\`\`bash
cd yourRepository
\`\`\`

## Execution

### Run Locally in Visual Studio

1. Open the `.sln` file in Visual Studio.
2. Make sure the API project is set as the startup project.
3. Press `F5` to start debugging, or click `Start Debugging` from the `Debug` menu.

Your API should now be running locally. Open a browser and navigate to `http://localhost:<your_port>` to test it.

### Run with Docker

1. Open a terminal and navigate to the project directory.
2. Build the Docker image:

   \`\`\`bash
   docker build -t yourImageName .
   \`\`\`

3. Run the Docker container:

   \`\`\`bash
   docker run -p yourPort:80 yourImageName
   \`\`\`

Your API should now be running inside a Docker container. Open a browser and navigate to `http://localhost:<your_port>` to test it.

## Usage

Include example requests and responses, as well as any additional features the API may have.

## Contributing

If you would like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## License

State your license here, or link to it.
