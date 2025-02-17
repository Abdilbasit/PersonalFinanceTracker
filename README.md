# Personal Finance Tracker

**Personal Finance Tracker** is a desktop application built with WPF and the MVVM design pattern, designed to help users manage their incomes and expenses. It leverages Entity Framework Core with an in-memory SQLite database to provide local data persistence. This project showcases modern C# desktop development practices, clean UI design, and maintainable code architecture.

## Features

- **Track Transactions:** Add, view, and manage financial transactions.
- **User-Friendly Interface:** Built with WPF for a rich, interactive user experience.
- **MVVM Pattern:** Utilizes the MVVM pattern for separation of concerns and easy maintenance.
- **Local Data Persistence:** Uses an in-memory SQLite database via Entity Framework Core.
- **Real-Time Updates:** The application dynamically updates the transaction list as new transactions are added.

## Technologies Used

- **C# & .NET 6:** Core programming language and runtime.
- **WPF (Windows Presentation Foundation):** For building the desktop UI.
- **MVVM (Model-View-ViewModel):** Architectural pattern for separation of concerns.
- **Entity Framework Core:** For data access and local database management.
- **SQLite (in-memory):** Lightweight database for data persistence during application runtime.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 (or another IDE that supports WPF development) with the .NET desktop development workload

### Installation

1. **Clone the Repository:**
    ```bash
    git clone <repository-url>
    cd PersonalFinanceTracker
    ```

2. **Open the Solution:**
   Open `PersonalFinanceTracker.sln` in Visual Studio.

3. **Build the Project:**
   Build the solution in Visual Studio to restore NuGet packages and compile the project.

### Running the Application

1. Set the startup project to `PersonalFinanceTracker` in Visual Studio.
2. Press `F5` or click on **Start Debugging** to run the application.
3. The main window will appear where you can add new transactions and view the list of existing transactions.


