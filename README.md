# AdvancedRoleBasedAccessControlSystem-dotnet-IngotAssignment
A secure web application developed using .NET Core with advanced role-based access control (RBAC) system, JWT authentication, and Entity Framework Core for ORM. Implements user registration, login, and secured endpoints.

## Setup Instructions

Follow these steps to set up and run the project locally:

1. **Clone the Repository:**


2. **Configure Database Connection:**

- Open the `appsettings.json` file located in the root directory of the project.
- Replace the placeholder values in the `ConnectionStrings` section with your actual database credentials.
- Ensure that you have a SQL Server instance running and create a database named `RoleBasedAccessDB`.

3. **Configure JWT Secret:**

- In the `appsettings.json` file, replace the placeholder value in the `JWT` section with your desired JWT secret.

4. **Build and Run the Application:**

- Navigate to the root directory of the project.
- Run the following commands to build and run the application:

  ```
  dotnet build
  dotnet run
  ```

5. **Test Endpoints:**

- Once the application is running, you can test the endpoints using the provided Postman collection.
- Import the Postman collection located at `postman/role-based-access.postman_collection.json` into Postman.
- Use the collection to test user registration, login, and access to secured endpoints.

6. **Explore the Codebase:**

- Feel free to explore the source code to understand how role-based access control and JWT authentication are implemented.
- Refer to the `Startup.cs` file for configuration related to JWT authentication.

## Postman Collection

- The `postman/role-based-access.postman_collection.json` file contains a collection of requests to test all endpoints of the application.
- Import this collection into Postman to execute requests and verify the functionality of the application.

## Feedback and Contributions

If you have any feedback or suggestions for improvement, please feel free to open an issue or submit a pull request.
