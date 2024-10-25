# C-and-.NET-Framework---Part-2
## MethodApp
Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen. 

In the Main() method of the console app, instantiate the class.

Call the method in the class, passing in two numbers. 

Call the method in the class, specifying the parameters by name.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

## EmployeeComparisonApp
Create an Employee class with Id, FirstName and LastName properties. 
In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. 

In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. Then compare the two Employee objects using the newly overloaded operators and display the results.
Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

## EmployeeComparisonPolymorphismApp

Create an interface called IQuittable and have it define a void method called Quit().

Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
