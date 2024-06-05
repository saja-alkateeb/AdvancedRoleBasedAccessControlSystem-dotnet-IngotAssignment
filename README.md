# AdvancedRoleBasedAccessControlSystem-dotnet-IngotAssignment

A secure web application developed using .NET 8 Core with advanced role-based access control (RBAC) system, JWT authentication, and Entity Framework Core for ORM. Implements user registration, login, and secured endpoints.

## Setup Instructions

Follow these steps to set up and run the project locally:

1. **Clone the Repository:**


2. **Configure Database Connection:**

- Open the `appsettings.json` file located in the root directory of the project.
- Replace the placeholder values in the `ConnectionStrings` section with your actual database credentials.
- Ensure that you have a SQL Server instance running and create a database named `RoleBasedAccessDB`.

3. **Connect to Database:**

   - **Using Generated Script:**
     - If you prefer using a generated SQL script, you can find it in the `DatabaseScript` file.
     - Execute the script in your SQL Server Management Studio to create the necessary tables and schema.

   - **Using Entity Framework Core Migrations:**
     - Open a terminal or command prompt.
     - Navigate to the root directory of the project.
     - Run the following commands to enable migrations, add migrations, and update the database schema:
       ```
       dotnet ef migrations enable
       dotnet ef migrations add InitialCreate
       dotnet ef database update
       ```

4. **Configure JWT Secret:**

- In the `appsettings.json` file, replace the placeholder value in the `JWT` section with your desired JWT secret.

5. **Build and Run the Application:**

- Navigate to the root directory of the project.
- Run the following commands to build and run the application of net 8 version :
  ```
  dotnet build
  dotnet run
   ```
  
6. **Test Endpoints:**

- Once the application is running, you can test the endpoints using the provided Postman collection.
- Import the Postman collection located at `postman/role based access control.postman_collection.json` into Postman.
- Use the collection to test user registration, login, and access to secured endpoints.

7. **Explore the Codebase:**

- Feel free to explore the source code to understand how role-based access control and JWT authentication are implemented.
- Refer to the `program.cs` file for configuration related to JWT authentication.

## JWT Authentication

JSON Web Tokens (JWT) are used for secure authentication within this application. JWT is a compact, URL-safe means of representing claims to be transferred between two parties. In this project, JWT is utilized for:

- **Authentication:** Users are issued a JWT upon successful login, which they include in subsequent requests to access protected endpoints.
- **Authorization:** The JWT contains claims about the user, including their role, which are used to enforce role-based access control (RBAC) for accessing different endpoints.
- **Security:** JWTs are digitally signed using a secret key to ensure their integrity and authenticity. This prevents unauthorized users from tampering with or creating fake tokens.

JWT configuration and middleware setup can be found in the `program.cs` file.

## Postman Collection

- The `postman/role based access control.postman_collection.json` file contains a collection of requests to test all endpoints of the application.
- Import this collection into Postman to execute requests and verify the functionality of the application.

## Feedback and Contributions

If you have any feedback or suggestions for improvement, please feel free to open an issue or submit a pull request.



