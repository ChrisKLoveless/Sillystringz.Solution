# Dr.Sillystringz's Factory

## Contributors

* Chris Loveless

## Description
This project is a simple web application for a business to keep track of Engineers and the Machines that they are licensed to service. Engineers and Machines have a many to many relationship meaning each 
Machine can be serviced by many Engineers, and an Engineer can service many Machines. The application allows the user to create, update, delete, and view lists of the Engineers they employ and their corresponding Machines. The app also includes fields for dates and time of last service for Machines and hire date for Engineers. 

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/ChrisKLoveless/Sillystringz.Solution.git``` to the ```Desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```Factory``` and restore with ```$ dotnet restore```
* While in the ```Factory``` directory use ```$ dotnet build``` to build the program.

## Database Setup

* To connect a database, create file ```appsettings.json``` in the production directory ```Factory```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* To include this projects data and structure, change directory to ```Factory```, and run ```dotnet ef update```
* While in the ```Factory``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Known Bugs

* If any bugs are found please email a brief description to: ```chriskloveless@gmail.com```

## License
Copyright (c) 2022 Chris Loveless
_[MIT](https://choosealicense.com/licenses/mit/)_