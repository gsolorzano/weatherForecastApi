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

```bash
cd weatherForecastApi
```

## Execution

### Run Locally in Visual Studio

To run locally in Visual Studio you require to create the mongoDB required by the service.
In this repo there is a script which will create a docker container with the mongoDB and mock data.

To run the container initialization:

1. Open a command line in the `DB` folder located in the root of the repo
2. Run the following command:

```bash
pwsh ./setupMongo.ps1
```

To run locally the API:

1. Open the `.sln` file in Visual Studio.
2. Make sure the WeatherAPI project is set as the startup project.
3. Press `F5` to start debugging, or click `Start Debugging` from the `Debug` menu.

Your API should now be running locally, it will automatically open a tab on the default browser with the swagger UI.

### Run with Docker

You can also run both the mongoDB and API in a docker image. In the repo there is script which will create the docker image.

To run the script:

1. Open a terminal and navigate to the `Solution Items` folder
2. Run the following command:

```bash
pwsh ./createImage.ps1
```

Your API should now be running inside a Docker container. Open a browser and navigate to `http://localhost:8000/swagger/index.html` to test it.

## Contributing

If you would like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## License

This project is licensed under the MIT License.
