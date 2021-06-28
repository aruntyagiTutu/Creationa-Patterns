Singleton pattern, 
   is a software design pattern that restricts the instantiation of a class to one "single" instance.

Scenario: 
    - Create instance of database.

Why we need Singleton ?

    - any class which can be reused throughout lifecycle of application should be a singleton.
Problem
    - making it a static class is a bad idea, Because you will not be able to do DI,
    - testing is almost for Singleton, though DI can help here