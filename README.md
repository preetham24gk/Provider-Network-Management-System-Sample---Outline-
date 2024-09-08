# Provider Network Management System (Sample - Outline)
In this project, we will follow the n-tier architecture to separate concerns, which will improve scalability and maintainability. Here’s a folder structure:

- Solution
  - Domain (for Entities and Business Logic)
  - Data (for Repositories and Data Access)
  - Services (for Business Rules and Implementation of Patterns)
  - WebAPI (for API Controllers)
  - UI (for Web Frontend)
 

  API Endpoints:

    GET /api/providers: This endpoint is used to retrieve the list of providers from our database (either SQL Server or MongoDB, depending on how we configure it).
    POST /api/providers: This endpoint allows us to add a new provider by submitting the necessary details in the body of the request.

  Schemas:

    Provider Schema: Lists all the properties of a provider such as providerId, name, specialty, location, and contracts.
    Contract Schema: Lists the properties for a contract, including contractId, contractDetails, startDate, endDate, providerId, and provider.

  Confirmation:

    This Swagger documentation means our API has been successfully set up, and our ASP.NET Core Web API is running without any critical issues.
    Now we can use the Swagger interface to test the endpoints directly by performing GET and POST operations, which will interact with the underlying database and business logic.
