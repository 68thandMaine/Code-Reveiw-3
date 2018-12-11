# Haircountability
### _Designed By_
_Chris Rudnicky_   
_07 December, 2018_

---

*Haircountability* is a time management MVC application intended for use with hair salons.

Managing the clients that each stylist sees in a given day is not an easy task. With *Haircountability* you can easily assign clients to different employees at your hair salon to improve scheduling efficiency and reduce overall labor cost.

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

## Application Testing  
**Haircountability** was tested using the MSTest framework. Prior to implementation, the class methods were tested to fail and the controllers were tested to fail as well. After failing the tests, passing code was entered and tested. If a test passed, the code was added to the final version of the application. For further information on application testing click one of the following links:
- [Stylist Testing Specs](../master/StylistModelTestSpecs.md)
- [Client Testing Specs](../master/ClientModelTestSpecs.md)
- [Controller Testing Specs](../master/ControllerSpecs.md)

###







## Client Testing  
 _The client is the child object in this application, thus it will be tested first._

[SqlCommands](../master/SqlCommands.md)

## Known Errors

###Additional Resources
