# Haircountability
### _Designed By_
_Chris Rudnicky_   
_07 December, 2018_

---
*Haircountability* is a time management MVC application intended for use with hair salons.
Managing the clients that each stylist sees in a given day is not an easy task.   
With *Haircountability* you can easily assign clients to different employees at your hair salon to improve scheduling efficiency and reduce overall labor cost.

---
## Table of Contents
**[Installation Instructions](#installation-instructions)**<br>
**[Usage Instructions](#usage-instructions)**<br>
**[Application Testing](#application-testing)**<br>
**[Known Errors](#known-errors)**<br>
**[Technologies Used](#technologies-used)**<br>
**[Acknowledgements](#acknowledgements)**<br>
**[Additional Resources](#additional-resources)**<br>

---
## Installation Instructions
### To Build Haircountability
1. Open a new command line and clone this repo with the following command:  
  >`$ git clone https://github.com/68thandMaine/hairsalon.git`
2. Navigate to the HairSalon folder, install packages, and build the app with the following commands.
  >`$ cd HairSalon.Solution`  
  >`$ cd HairSalon`  
  >`$ dotnet restore`  
  >`$ dotnet build`  

### Setup Databases
  _**Haircountability** uses SQL databases to manage client/stylist relations. To use **Haircountability** you will need to:_
  1. Install [MAMP](https://www.mamp.info/en/downloads/). MAMP will attempt to install both MAMP and MAMP pro, the latter of which requires a subscription. For **Haircountability** to run we only need MAMP. For detailed instructions for how to configure MAMP settings click [here](https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-and-configuring-mamp).  
  2. Open MAMP and start servers.
  3. Using myPHPAdmin, import the database named chris_rudnicky.

### Run the application  
- After building the application and setting up the application enter the following command into the termnial while in the `ToDoList` subdirectory:  
  >` $dotnet run`

#### Haircountability should build and run correctly!
---
## Usage instructions
After successfully building and launching the application...
1. Open a connection to localhost:5000 in Chrome/Safari/Firefox etc...
2. You will see the "splash" page of the application where two options are presented:
    - View employees
    - Add a new stylist
3. Assuming this is the first time using **Haircountability**, click Add a new stylist to create the first employee. You may create as many stylists as necessary.
4. The View employees link will route to a list of all employees held in **Haircountability**.
5. Clicking on an employee will allow a user functionality to add a new client to the particular stylist.
6. Client information can be edited, and a list of clients can be cleared from a particular stylist through clicking on a clients name.
7. To exit **Haircountability** press the following keys while in the terminal window running **Haircountability**:  <strong>`ctrl+c`</strong>.
---
## Application Testing  
**Haircountability** was tested using the MSTest framework. Prior to implementation, the class methods were tested to fail and the controllers were tested to fail as well. After failing the tests, passing code was entered and tested. If a test passed, the code was added to the final version of the application. For further information on application testing click one of the following links:
- [Client Testing Specs](../master/ClientModelTestSpecs.md)
- [Stylist Testing Specs](../master/StylistModelTestSpecs.md)
- [Controller Testing Specs](../master/ControllerSpecs.md)
---
## Known Errors
There are currently no known errors in **Haircountability**.   
Upon encountering an error _**swiftly**_ email me at chrisrudnicky@gmail.com

---
## Technologies Used
Below is a complete list of all technologies used to build **Haircountability**:
- [Atom](https://atom.io/)
- [MAMP](https://www.mamp.info/en/downloads/)
- [.NET Core Software Development Kit](https://docs.microsoft.com/en-us/dotnet/)
- [MONO](https://www.mono-project.com/docs/)
- [phpMyAdmin](https://www.phpmyadmin.net)
---
## Acknowledgements
- **Haircountability**  was based off of the Epicodus C# independent project for [Database Basics](https://www.learnhowtoprogram.com/c/database-basics-ee7c9fd3-fcd9-4fff-8b1d-5ff7bfcbf8f0/database-basics-independent-project-3a443c65-946b-43eb-ad00-96aca5bca3d2). Without guidance from the objectives and the previous lessons used to create a To Do List, I would not have been able to create this project.   
- Additionally, the [work flow markdown file that Tanvi Garg](https://github.com/TanviCodeLife/to-do-list-mvc/blob/master/WorkFlow.md) wrote proved especially helpfu l for planning my methods and controller routes.
- github user [adam-p](https://github.com/adam-p/markdown-here/blob/master/README.md) whose file on ReadMe's and [Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet)were invaluable tools for designing this ReadMe.

---
## Additional Resources
- [SqlCommands](../master/SqlCommands.md) - See a list of the SQL commands used to create the databases used by **Haircountability**
