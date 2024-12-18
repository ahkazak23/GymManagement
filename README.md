# Gym Membership Management System

A comprehensive Gym Membership Management System designed to streamline the administration of gym members, memberships, and payments. Built using C#, the application provides an easy-to-use interface for gym managers and administrators.

---

## Features

### Core Features
- **Member Management**:
  - Add, edit, and delete gym members.
  - Search and filter members by name, membership type, or other attributes.
- **Membership Management**:
  - Manage membership types (e.g., Monthly, Quarterly, Yearly).
  - Track membership start and end dates.
  - Automatic membership status updates (active/inactive).
- **Payment Management**:
  - Record payments made by members.
  - Track overdue payments and notify admins.
- **Admin Features**:
  - Role-based access control.
  - Admin panel for system settings and logs.

### User Interface
- Intuitive tab-based navigation for quick access to core functionalities.
- Responsive sidebar for easy menu access and a clean interface.
- Interactive forms for CRUD operations (Create, Read, Update, Delete).

---

## Technologies Used

### Frontend
- **Windows Forms (WinForms)**: For designing the user interface.
- **ReaLTaiizor Library**: For modern UI components and controls.

### Backend
- **C#**: Core programming language used for business logic.
- **Entity Framework**: ORM for database operations.
- **BCrypt.Net**: For secure password hashing.
- **System.Data.SQLite**: Lightweight database for storing data.

### Database
- **SQLite**: A file-based database solution for local data storage.

### Tools
- **Rider IDE**: Development environment for managing the project.
- **Git**: Version control system.

---

## Setup Instructions

### Prerequisites
1. Install [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework).
2. Install a development environment like Rider, Visual Studio, or any IDE supporting C#.

### Clone the Repository
```bash
git clone https://github.com/ahkazak23/GymManagement.git
cd GymManagement
```

### Run the Application
1. Open the solution file (`GymManagement.sln`) in your IDE.
2. Restore NuGet packages if prompted.
3. Build the project using the IDE's build tool.
4. Run the project (F5 or Debug > Start Debugging).

### Database Configuration
- The system uses a pre-configured SQLite database file (`gym.db`).
- To reset the database, replace the existing `gym.db` file with a new one, or modify the `SQLiteConnectionFactory` class in the `DAL` project to point to a different file.

---

## Project Structure

```
GymManagement/
├── BLL/                     # Business Logic Layer
│   ├── Managers/            # Handles core business operations
│   ├── bin/                 # Build output directory
│   └── obj/                 # Build intermediate files
├── DAL/                     # Data Access Layer
│   ├── Repositories/        # Handles database interactions
│   ├── SQLiteConnectionFactory.cs
│   ├── bin/                 # Build output directory
│   └── obj/                 # Build intermediate files
├── Models/                  # Entities representing database tables
├── UI/                      # User Interface Layer
│   ├── Forms and UserControls
│   ├── Resources/           # Images and icons
│   ├── bin/                 # Build output directory
│   └── obj/                 # Build intermediate files
├── Tests/                   # Unit tests for the application
├── gym.db                   # SQLite database file
├── GymManagement.sln        # Solution file
└── .gitignore               # Git ignored files
```

---

## Usage

### Login
- Default admin credentials:
  - **Username**: `admin`
  - **Password**: `password`

### Adding a Member
1. Navigate to the "Member Management" tab.
2. Click `Add Member` and fill in the required details.
3. Save the new member.

### Managing Memberships
1. View member details and select the "Membership" tab.
2. Modify membership type and validity dates.
3. Save changes to update the membership.

### Payment Tracking
1. Navigate to the "Payments" tab.
2. View payment history or record a new payment.
3. Save changes to update payment logs.

---

## Contribution Guidelines

### Reporting Issues
If you encounter any bugs or have feature requests, please open an issue in the [issue tracker](https://github.com/ahkazak23/GymManagement/issues).

### Pull Requests
1. Fork the repository.
2. Create a new branch (`feature/your-feature`).
3. Commit your changes.
4. Push to your fork and submit a pull request


---

## Contact
For questions or support, contact **Alihan Kazak** at [ahkazak23@gmail.com](mailto:ahkazak23@gmail.com).
