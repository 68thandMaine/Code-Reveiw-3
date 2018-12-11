# Haircountability
### _Designed By_
_Chris Rudnicky_   
_07 December, 2018_

---

*Haircountability* is a time management MVC application intended for use with hair salons.

Managing the clients that each stylist sees in a given day is not an easy task. With *Haircountability* you can easily assign clients to different employees at your hair salon to improve scheduling efficiency and reduce overall labor cost.

---

## Installation
#### To Build Haircountability
1. Open a new command line and clone this repo with the following command:  
  >`$ git clone https://github.com/68thandMaine/hairsalon.git`
2. Navigate to the HairSalon folder, install packages, and build the app with the following commands.
  >`$ cd HairSalon.Solution`  
  >`$ cd HairSalon`  
  >`$ dotnet restore`  
  >`$ dotnet build`  

#### Setup Databases
  _**Haircountability** uses SQL databases to manage client/stylist relations. To use **Haircountability** you will need to:_
  1. Install [MAMP](https://www.mamp.info/en/downloads/). MAMP will attempt to install both MAMP and MAMP pro, the latter of which requires a subscription. For **Haircountability** to run we only need MAMP. For detailed instructions for how to configure MAMP settings click [here](https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-and-configuring-mamp).  
  2. Open MAMP and start servers.
  3. Using myPHPAdmin, import the database named chris_rudnicky.

#### Run the application  
- After building the application and setting up the application enter the following command into the termnial while in the `ToDoList` subdirectory:  
  >` $dotnet run`

###### Haircountability should build and run correctly!

# Running the tests

## Client Testing  
 _The client is the child object in this application, thus it will be tested first._

[SqlCommands](../master/SqlCommands.md)

## Known Errors

###Additional Resources
