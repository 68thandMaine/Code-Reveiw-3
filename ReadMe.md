# Haircountablitity
### _Designed By_
_Chris Rudnicky_   
_07 December, 2018_

---

## Description
> *Haircountablitity* is a MVC application that uses a one to many relational database to assign clients to stylists at a hair salon.

## Installation

## Running the tests
### Client Testing  
1. The client is the child object in this application, thus it will be tested first.
#### Test to see if the constructor creates an appropriate instance of the Client type.
>We will not be able to fail this test without a compile error, thus the only test we need is a passing test. A passing test means that .NET is working correctly.
#### Test to see if the get methods return the correct values.

  ##### `GetName()`  

  FAIL:  
>To fail this test our `public void  GetName()` returns a string that is not equivalent to the name passed into the Client constructor.  

  PASS:  
 >To pass this test our `public void  GetName()` should `return _name`.

  ##### `GetId()`  

    FAIL:
 >To fail this test our `public void  GetId()` returns an integer that is not equivalent to the name passed into the Client constructor.  

  PASS:  
 >To pass this test our `public void  GetId()` should `return _id`.

  #### Test to see if the Database correctly returns an empty list.  

  ##### `GetAll()`

  FAIL:
  >To fail this test our `public static List<Client> GetAll()` will return a dummy list that is not connected to the database. This s because our test database is already an empty database. The dummy List<Client> will contain an object in it.

  PASS:
>To pass this test our `public static List<Client>GetAll()` will return the test database. We replaced the dummy list with a SQL command that returns the test database. 



## Known Errors

###Additional Resources
