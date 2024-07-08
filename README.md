# MiaAcademyAutomation

This repository contains automation tests for navigating through the MiaAcademy website and performing specific actions using Selenium WebDriver, NUnit, and ExtentReports.

## Overview

The automation tests included in this project perform the following steps:
1. Navigate to [MiaAcademy](https://miacademy.co/#/).
2. Navigate to MiaPrep Online High School through the link on the banner.
3. Apply to MOHS (MiaPrep Online High School).
4. Fill in the Parent Information.
5. Proceed to the Student Information page.
6. Stop the test here.

The test reports are saved in an `index.html` file, and the test cases are defined in the `basetest`.

## Project Structure
MiaAcademyAutomation/
├── MiaAcademyAutomation.csproj
├── Source/
│ ├── Pages/
├──Utilities/
│ ├── TestHooks.cs/
├── BaseTests/
│ └── WebTests.cs
├── bin/
├── obj/
├── Datadriventesting.cs
├── index.html
├── User.cs
├── users.json
└── README.md

- **MiaAcademyAutomation.csproj**: The project file for the .NET automation test project.
- **Source/Drivers**: Contains driver-related classes and configurations.
- **Source/Pages**: Contains page object model classes representing different pages on the website.
- **Source/Utilities**: Contains TestHooks classes including `Drivers and Extent Reports` for setup and teardown.
- **BaseTests/WebTests.cs**: Contains the test cases.
- **index.html**: The HTML report generated by ExtentReports.
- **users.json**: The json file conatins test data.
- **User.cs**: Calling test data using get and set.
- **Datadriventesting.cs**: Using this class, loading the testdata of users from json file.
- **README.md**: This readme file.

## Setup and Execution

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Chrome WebDriver](https://sites.google.com/a/chromium.org/chromedriver/downloads)
- [Nunit Automation Framework]
- [Selenium Webdrivers]
  


### Getting Started

1. **Clone the repository**:
    ```bash
    git clone https://github.com/sanas12/MiaAcademyAutomation.git
    cd MiaAcademyAutomation
    ```

2. **Install dependencies**:
    **Manage NuGet Packages**

3. **Run the tests**:
    **Tests Explorer**

### Test Report

After running the tests, an HTML report will be generated and saved as `index.html` in the root directory. You can open this file in any web browser to view the test results.

## Writing and Running Tests

- **Base Test Class**: Inherit from `TestHooks` to leverage Drivers and Extent Reports setup and teardown functionality.
- **Creating Tests**: Define test methods in `WebTests.cs` using `[Test]` attribute.
- **Running Tests**: Execute tests using `dotnet test` command or using `Tests
