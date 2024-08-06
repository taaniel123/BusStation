# BusStation

## Description

A C# application for managing bus station time entries and calculating the busiest time periods.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/taaniel123/BusStation.git
   ````
2. Restore the dependencies:
   ```bash
   dotnet restore
   ````
## Usage

## Running the application

To run the application with a file:
   ```bash
    dotnet run times.txt
   ````

To run the application and input time entries manually:
   ```bash
    dotnet run
   ````

Enter time entries in the format HH:mm-HH:mm and type exit when done.

## Running tests

To run the tests:
   ```bash
    dotnet test
   ````