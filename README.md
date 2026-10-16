# PROG-Part2
# RaceDay – Running, Walking and Cycling Event Management API

 1. Project Overview

RaceDay is a web-based event management system designed to manage running, walking and cycling events. The system provides a central platform where organisers can create and manage events, while participants can register, enter events, select categories and view their race results.

The project is developed using ASP.NET Core Web API with C# and Microsoft SQL Server. Entity Framework Core is used to manage communication between the application and the database. The API provides endpoints that allow users and other applications to access and manage event-related information.

The main purpose of RaceDay is to simplify event administration, improve the accuracy of participant records and make race information easier to access.

 2. Project Objectives

The objectives of RaceDay are to:

- Develop a reliable API for managing running, walking and cycling events.
- Allow organisers to create, update and manage events.
- Allow participants to register, maintain their profiles and enter available events.
- Organise events into suitable categories.
- Record finishing times and finishing positions.
- Protect user information through authentication and role-based authorisation.
- Store application data in a structured SQL Server database.
- Test the application and use GitHub Actions to automate build checks.

 3. User Roles

Organiser

An organiser is responsible for managing sporting events. Depending on their permissions, an organiser can:

- Create new events.
- Update event details.
- Delete events when appropriate.
- Create and manage event categories.
- View participant enrolments.
- Record and update race results.

Participant

A participant is a person who takes part in sporting events. Participants can:

- Register for an account and log in.
- View and update their own profile.
- Browse available events.
- View event categories.
- Enrol in events and select a suitable category.
- View their own race results.

Access to protected functions must be restricted according to the user's role.

4. Technologies Used

 Technology Purpose 
 C# - Main programming language 
ASP.NET Core Web API, Develops the API and HTTP endpoints 
 Entity Framework Core, Maps application models to database tables 
 Microsoft SQL Server, Stores user, event, enrolment and result data 
 Visual Studio, Development and debugging environment 
 Swagger / OpenAPI, Documents and tests API endpoints during development 
 Git and GitHub, Source control and project collaboration 
 GitHub Actions, Automates build and test checks 
 xUnit or another supported test framework, Tests application functionality 

The exact versions of .NET and the NuGet packages depend on the project's configuration.

 5. System Features

- User and Profile Management

The system supports account registration and login. Users can access and update their profile information. Passwords should be securely hashed rather than stored as plain text.

-Event Management

Organisers can manage event information, including the event name, description, date, location, distance and event type.

- Category Management

Events can contain categories to help organise participants according to the rules of each event. Category information may include age or distance requirements.

-Enrolment Management

Participants can enrol in events and select an appropriate category. The system records enrolment information and helps organisers view the participants registered for an event.

- Results Management

Organisers can record finishing times and finishing positions for participants. Participants can retrieve their own results through the relevant API endpoints.

- Security and Access Control

Authentication identifies the user making a request. Authorisation determines whether that user is permitted to perform the requested action. Organiser-only functions must not be accessible to ordinary participants.

6. Database Design

RaceDay uses a relational database called `RaceDayDB`. The planned database contains the following main entities:

- **Users:** Stores account details, email addresses, password hashes and roles.
- **Organisers:** Stores information specific to event organisers.
- **Participants:** Stores information specific to participants.
- **Events:** Stores sporting event details.
- **Categories:** Stores the categories available for each event.
- **Enrollments:** Records the participants enrolled in events and their selected categories.
- **Results:** Stores finishing times and finishing positions associated with enrolments.

 7. API Endpoint Plan

The following endpoints form the planned API structure. An endpoint is complete only when it has been implemented and tested.

| Method | Endpoint | Purpose |
|---|---|---|
| POST | `/api/auth/register` | Register a user |
| POST | `/api/auth/login` | Authenticate a user |
| GET | `/api/profile` | Retrieve the current user's profile |
| PUT | `/api/profile` | Update the current user's profile |
| GET | `/api/events` | Retrieve available events |
| GET | `/api/events/{id}` | Retrieve a specific event |
| POST | `/api/events` | Create an event |
| PUT | `/api/events/{id}` | Update an event |
| DELETE | `/api/events/{id}` | Delete an event |
| GET | `/api/events/{eventId}/categories` | List categories for an event |
| POST | `/api/events/{eventId}/categories` | Create a category |
| PUT | `/api/categories/{id}` | Update a category |
| DELETE | `/api/categories/{id}` | Delete a category |
| POST | `/api/enrollments` | Enrol in an event |
| GET | `/api/enrollments/my` | View the current participant's enrolments |
| GET | `/api/events/{eventId}/enrollments` | View enrolments for an event |
| POST | `/api/enrollments/{enrollmentId}/result` | Record a result for an enrolment |
| PUT | `/api/results/{id}` | Update a result |
| GET | `/api/results/my` | View the current participant's results |
| GET | `/api/events/{eventId}/results` | View results for an event |

Some endpoints require authentication and role-based authorisation. The final endpoint list must reflect the routes actually implemented in the project.

8. Installation and Setup

- Steps to Run the Project

1. Clone or download the RaceDay repository from GitHub.
2. Open `RaceDay.sln` in Visual Studio.
3. Restore the required NuGet packages.
4. Check the database connection string in `appsettings.json`.
5. Confirm that the connection string points to the intended SQL Server instance and `RaceDayDB` database.
6. Build the solution and resolve any compilation errors.
7. Inspect the database schema and migration history before applying any migrations.
8. Run the API using Visual Studio.
9. Open the Swagger interface provided by the running application to explore and test the available endpoints.


