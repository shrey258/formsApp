# Forms Desktop Application

## Description

This project is a Windows Desktop Application developed using Visual Studio and Visual Basic. The application provides functionalities to create and view submissions with additional features like editing and deleting submissions, along with searching by email.

## Features

### Compulsory Features
1. **Create New Submissions**
   - Form fields: Name, Email, Phone Number, GitHub repo link, Stopwatch (with resume/pause functionality).
   - Keyboard shortcut: `Ctrl + S` to submit the form.

2. **View Submissions**
   - Navigate through submissions using "Previous" and "Next" buttons.
   - Display the first submission by default.
   - Keyboard shortcuts: `Ctrl + P` for Previous and `Ctrl + N` for Next.

### Additional Features
1. **Edit Submissions**
   - Editable fields within the View Submissions form.
   - Button to toggle edit mode and save changes.

2. **Delete Submissions**
   - Option to delete submissions from the View Submissions form.

## Installation and Setup

### Prerequisites

- Visual Studio (not Visual Studio Code)
- Windows OS

### Steps to Run the Application

1. **Clone the Repository**
   ```sh
   git clone https://github.com/shrey258/formsApp.git
   cd formsApp

2. **Open the Project in Visual Studio**
    - Open Visual Studio.
    - Select File > Open > Project/Solution.
    - Navigate to the cloned repository directory and select the solution file (.sln).

3. **Build the Project**
    - Press Ctrl + Shift + B to build the project.
    - Ensure there are no build errors.

4. **Run the Application**
    - Press F5 to run the application.

    ![image](https://github.com/shrey258/formsApp/assets/91644557/3b857d9a-bbec-40f8-95e4-98952c885b92)

## Usage

### Create New Submission
  - Click on the "Create New Submission" button.
  - Fill in the required fields.
  - Use the stopwatch button to start and pause the timer.
  - Submit the form using the "Submit" button or Ctrl + S.
    
  ![image](https://github.com/shrey258/formsApp/assets/91644557/e2b1e2cc-2ce8-41c5-95fe-ede2e1bdb936)

### View Submissions
  - Click on the "View Submissions" button.
  - Use the "Previous" and "Next" buttons to navigate through submissions.
  - To edit a submission, click the "Enable Edit" button, make the changes, and then click "Save Changes".
  - While viewing a submission, click the "Delete" button to remove the submission.

  - View Mode:
  - ![image](https://github.com/shrey258/formsApp/assets/91644557/524c3435-8ba2-4752-8092-b6c9287f42b2)

  - Edit Mode:
  - ![image](https://github.com/shrey258/formsApp/assets/91644557/6e3601fc-2765-40ae-9c0d-d73b3f3c98b3)

## Project Structure
  - Form1.vb: Contains the main form with buttons to navigate to submission forms.
  - CreateSubmissionForm.vb: Contains the form to create new submissions.
  - ViewSubmissionForm.vb: Contains the form to view, edit, and delete submissions.

## Backend Server
  Ensure the backend server is running to handle API requests. Refer to the backend repository for setup instructions.
  - https://github.com/shrey258/formsAppBackend






