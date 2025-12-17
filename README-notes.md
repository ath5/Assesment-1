#Note on Implementation

## What I have Built 
I completed the backendpart of the commission calculato using ASP.NET Core.
The API exposes a single POST endpoint that calcultes the comission amounts for Avalplha Technologies and a competitor based on the given inputs.

## How it works
- The controller handles basic request validation (negative values, unrealistic inputs).
- The actual commission calculation logic is kept in a small service class.
- Commission percentages are defined as constants to make the logic easy to follow and change.

## Validation
- Sales counts must be zero or greater than zero.
- Average sale amount must be zero or greater than zero.
- A reasonable upper limit is applied to sales counts to avoid unrealistic values.


## Testing
- Unit tests are written for the calculation service using xUnit.
- The tests focus on verifying correct commission calculations and edge cases.
- Controller behavior was verified using the provided `.http` file.

## Frontend
The backend API is ready to be consumed by the provided React application.  
Due to time constraints and the focus of this exercise, the frontend logic was kept minimal and the main effort was spent on delivering a correct and testable backend implementation.

## Running the project
1. Install .NET 8 SDK or ASP.NET Core Runtime.
2. Run the API using IIS Express or the 'dotnet run'.
3. Use Postman or the provided 'http' file to call the `/Commission` endpoint.
