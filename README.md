# Library Management System (WinForms)

## About the Project
This is a Library Management System developed using C# and Windows Forms.  
I created this project to practice object-oriented programming and to better understand how to structure an application using separate domains (namespaces) and references between them.

The application allows users to manage different types of books in a simple and organized way.

---

## Features
- Add new books with input validation
- Support for different book types:
  - Printed books
  - EBooks
  - AudioBooks
- Edit and delete books using a DataGridView
- Save the book list to a text file
- Clear separation between logic and UI

---

## Architecture & Structure
The project is organized into multiple domains (namespaces) to keep the code clean and maintainable:

- **Information**  
  Contains the core domain logic, including the abstract `BookInfo` class, derived book types, and the `BookFactory`.  
  This domain is referenced by other parts of the application.

- **Library**  
  Contains the main WinForms UI for adding and displaying books.  
  This layer references the `Information` domain.

- **EditLip**  
  Handles editing and deleting existing books in a separate form.  
  It works with cloned objects to avoid direct modification of the original data.

This structure helped me understand how to work with domains, namespaces, and references in a real WinForms project.

---

## Concepts Used
- Object-Oriented Programming (OOP)
- Inheritance, Abstraction, Polymorphism
- Factory Design Pattern
- Namespaces and project references
- WinForms event handling and validation
- Working with collections (`List<T>`) and DataGridView

---

## What I Learned
Through this project, I improved my understanding of:
- Structuring a project using separate domains
- Sharing logic between different parts of an application using references
- Applying design patterns in practice
- Keeping business logic separate from UI code

---

## Screenshots

### Main Library Form
<img width="703" height="401" alt="Screenshot (175)" src="https://github.com/user-attachments/assets/a3e31d99-5363-48b9-955e-c5d2c8da8d16" />

### Edit Books Form
<img width="994" height="430" alt="Screenshot (176)" src="https://github.com/user-attachments/assets/8aa77100-d089-4e1b-a694-a264eeed3836" />

### Save Book List
<img width="1270" height="422" alt="Screenshot (179)" src="https://github.com/user-attachments/assets/9dee6e19-928a-4c7e-b46f-a967f87c6a84" />

---

## How to Run
1. Open the solution file in Visual Studio  
2. Build the solution  
3. Run the application  

---

## Notes
This project was created for learning purposes and to showcase my C#.
