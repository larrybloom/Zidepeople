# BookManagementAPI

Overview
The Book Management API is a simple RESTful API for managing a collection of books. It supports basic CRUD operations (Create, Read, Update, Delete) and is built with .NET 8. This project demonstrates how to build a web API with in-memory data persistence and includes automated documentation with Swagger.

Features
POST /books: Add a new book.
GET /books: Retrieve a list of all books.
GET /books/{book_id}: Retrieve details of a specific book by its ID.
PUT /books/{book_id}: Update the details of a specific book by its ID.
DELETE /books/{book_id}: Delete a specific book by its ID.

Technologies Used
.NET 8
ASP.NET Core
Swagger (for API documentation)
Moq (for unit testing)
xUnit (for unit testing)

Prerequisites
.NET 8 SDK
Visual Studio 2022 or later (recommended) or any other preferred C# IDE
Setup and Installation
Clone the Repository:

sh
Copy code
git clone https://github.com/larrybloom/Zidepeople.git
cd BookManagementAPI
Open the Project:

Open the BookManagementAPI.sln solution file in Visual Studio or your preferred IDE.
Restore Dependencies:

Run the following command in the Package Manager Console or terminal:
sh
Copy code
dotnet restore
Run the Application:

You can run the application directly from Visual Studio by pressing F5 or using the following command in the terminal:
sh
Copy code
dotnet run --project BookManagementAPI
Access the API Documentation:

Once the application is running, navigate to https://localhost:5001/swagger or http://localhost:5000/swagger in your web browser to view the automatically generated API documentation.
Project Structure
Controllers: Contains the BooksController which handles HTTP requests and responses.
Models: Contains the Book class which defines the data model for the API.
Data: Contains the IBookRepository interface and its implementation BookRepository for data persistence.
Tests: Contains unit tests for the BooksController.
API Endpoints
Add a New Book:

http
Copy code
POST /api/books
Request Body:
json
Copy code
{
  "title": "New Book",
  "author": "Author Name",
  "publishedYear": 2023
}
Response: Returns the added book with its ID.
Get All Books:

http
Copy code
GET /api/books
Response: Returns a list of all books.
Get a Book by ID:

http
Copy code
GET /api/books/{book_id}
Response: Returns the book details if found.
Update a Book:

http
Copy code
PUT /api/books/{book_id}
Request Body:
json
Copy code
{
  "title": "Updated Book",
  "author": "Updated Author",
  "publishedYear": 2024
}
Response: Returns NoContent if successful or NotFound if the book does not exist.
Delete a Book:

http
Copy code
DELETE /api/books/{book_id}
Response: Returns NoContent if successful or NotFound if the book does not exist.
Running Unit Tests
The project includes unit tests for the API endpoints. To run the tests:

Navigate to the Tests Project Directory:

sh
Copy code
cd BookManagementAPI.Tests
Run the Tests:

sh
Copy code
dotnet test
Error Handling
The API includes basic error handling for invalid requests and missing resources.
Validation errors will return a 400 Bad Request status code with details about the validation issues.
Attempting to access or modify a non-existent book will return a 404 Not Found status code.
