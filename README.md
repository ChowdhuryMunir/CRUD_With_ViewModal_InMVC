# CRUD With Modal window In MVC

This repository contains an ASP.NET MVC application built using the .NET Framework, demonstrating CRUD (Create, Read, Update, Delete) operations with ViewModels. The application showcases how to use ViewModels for managing and presenting data, and includes a user-friendly modal/popup window feature for performing CRUD operations.

## Features

- **CRUD Operations**: Full support for Create, Read, Update, and Delete operations.
- **ViewModels**: Utilizes ViewModels to separate data management logic from the user interface.
- **ASP.NET MVC**: Implements the Model-View-Controller pattern for a well-structured application.
- **Modals/Popups**: Provides a seamless user experience with modal windows for CRUD operations, enhancing the user interface.
- **Data Validation**: Includes validation to ensure data integrity and accuracy.
- **User Interface**: Features an intuitive interface for interacting with data through Razor Views and modals.

## Technologies Used

- **ASP.NET MVC**: Framework for building web applications using the Model-View-Controller architecture.
- **Entity Framework**: ORM for database operations.
- **Razor Views**: View engine for generating dynamic HTML content.
- **Bootstrap**: Used for responsive modals and styling (if applicable).

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) with support for .NET Framework
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or a compatible database

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ChowdhuryMunir/CRUD_With_ViewModal_InMVC.git
   cd CRUD_With_ViewModal_InMVC
   ```

2. **Open the Solution**
   - Open the solution file (`.sln`) in Visual Studio.

3. **Update Database Connection String**
   - Open `web.config` and update the connection string:
     ```xml
     <connectionStrings>
       <add name="DefaultConnection" connectionString="Server=your_server;Database=your_database;User Id=your_user;Password=your_password;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

4. **Build the Project**
   - Build the project in Visual Studio to restore NuGet packages and compile the code.

5. **Run the Application**
   - Start the application using Visual Studio. It will run locally and be accessible at `http://localhost:your_port`.

## Project Structure

- **Models**: Contains the data models used with Entity Framework.
- **ViewModels**: Defines the ViewModels for data representation in the views.
- **Controllers**: Implements MVC controllers for managing user interactions and business logic.
- **Views**: Contains Razor views for rendering HTML and user interfaces, including modal dialogs for CRUD operations.
- **Content**: Static files like CSS, JavaScript, and images.

## Application Features

- **Create**: Modal form for adding new records without leaving the page.
- **Read**: Views to display lists and detailed records.
- **Update**: Modal form for editing existing records, providing an efficient user experience.
- **Delete**: Option to remove records through modals, confirming actions without navigating away.

## Usage

Open the application in your web browser at `http://localhost:your_port` to access the CRUD functionalities. Use the navigation and modal windows to manage data records effectively.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push the branch (`git push origin feature/your-feature`).
5. Open a pull request with a description of your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or feedback, please contact [MunirchowdhurySaif](https://github.com/chowdhuryMunir).
