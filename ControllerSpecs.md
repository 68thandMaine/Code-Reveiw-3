## Controller Testing
Because all controllers need three tests, this document will only document three tests. It can be assumed that all controllers were tested before releasing this app using the applicable tests from below.

1. The controller must be able to return to the correct view.  

  FAIL:  
>To fail a test for this, set the return value of `public ActionRestult Index()` to `return new EmptyResult`.  

  PASS
  >To pass a test for this, set the return value of`public ActionRestult Index()` to `return View();`.

2. The controller must be able to return the correct datatype to the View

3.
