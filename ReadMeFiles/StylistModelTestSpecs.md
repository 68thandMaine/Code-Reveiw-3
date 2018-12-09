
## Stylist Testing
_After testing child objects, test parent objects with similar tests._
##### `GetName()`  

FAIL:  
>To fail this test, our `public void  GetName()` returns a string that is not equivalent to the name passed into the Stylist constructor.  

PASS:  
>To pass this test, our `public void  GetName()` should `return _name`.

##### `public overrride bool Equals()`
_In order to compare objects made from the same constructor, we need an override so that our Equals method will see these objects as equivalent._

FAIL  
>To fail this test,  change the syntax in our override statement so that it returns false if two objects were created from the same constructor.

PASS
>To pass this test, alter the code so that if two objects were created from the same constructor, the for loop will set the values equal to each other so that `Equals` returns true.

##### `Save()`

FAIL
>To fail this test, our   `public void Save()` will not have any logic inside of it. Voids do not need to return anything, so by not including code we can compile the code and fail the test.

PASS
>To pass this test, our  `public void Save()` will contain the code for connecting to the Database and the SQL commands necessary for saving to the database.
##### `Find(int id)`

FAIL
>To fail this test, set the return to `public static Client Find(int id)` to a random hardcoded Stylist object.

PASS
>To pass this test, open a MySqlConnection and use SQL queries to find Stylists and return them based off of an Id.

##### `GetClients()`
_The GetClients method will match clients to stylists (child to parent) through matching primary keys and foreign keys_

FAIL  
>To fail this test have GetClients return an empty list and compare the empty list to a list that is hardcoded with clients.

PASS
>To pass this test, simply create a connection to the database and use a SQL command to search all columns in the child object table when stylist Ids match.
