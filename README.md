# GoogleFormsClone

GoogleFormsClone is an Express application built with TypeScript that mimics some of the functionality of Google Forms. It allows users to submit forms, retrieve, delete, and edit submitted form data.

## Features

- Submit form data including name, email, phone, GitHub link, and stopwatch time.
- Retrieve single form submissions by index.
- Delete form submissions.
- Edit form submissions.
- Store submissions in a JSON file (`db.json`).

## apis 
- /ping - A GET request that always returns True
- /submit - A POST request with parameters "name", "email", "phone", "github_link" and "stopwatch_time"
- /read - A GET request with query parameter "index" which is a 0-index for reading the (index+1)th form submission.
- /delete - A delete request to delete the form details.
- /update - A put request to edit the form details



## Prerequisites

Make sure you have the following installed:

- Node.js (v12.x or higher)
- npm (v6.x or higher)
- Visual Studio 2022 (for running the frontend desktop app)
- .NET SDK (for running the desktop app with Entity Framework)

### Set up Entity Framework
If you are using Entity Framework, make sure you have it installed and configured in your project. Here are the steps to install Entity Framework in your .NET project:



 ### Set up the database
 Here we are storing the form details in db.json file so no need any external database .

### Run the backend server
tsc
node dist/server.js

Your server should now be running on http://localhost:3000     ![Screenshot 2024-06-19 234805](https://github.com/Jahnavi-Undavalli/desktopApp/assets/105148914/35a99aeb-8708-42ff-bbfe-da785c2c037d)

![Screenshot 2024-06-19 234833](https://github.com/Jahnavi-Undavalli/desktopApp/assets/105148914/64080d38-4d9a-4768-b6f8-8d4ae27f8a2f)


