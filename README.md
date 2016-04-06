# C-6-features

This project is a quick look into the new language features in C# 6. Partly for my own reference when I forget exactly how these things work but mostly as an easy way to play with new toys :)

Each new feature is separated into a different namespace, each of which tries to only look into that particular feature. Inside each namespace is a test class with an nunit test fixture looking into each facet of the new features to show exactly how each one works. These are setup as unit tests to allow easy debugging to see how everything works.

##Quick Reference

###Auto Property Initializer
Set a default value for a property which can **only** be modified in the constructor
```C#
public string CustomerName { get; } = "Unknown";
```

###Exception Filtering
A `when` clause after the catch allows a predicate to be evaluated against the catch exception
```C#
catch (SeriousException ex) when (ex.ReallyIsSerious)
{
  //better handle the exception.
}
```

###Expression Bodied Members
Either sets up a function as a getter for a property:
```C#
public DateTime FiveDaysLater => DateTime.Now.AddDays(5);
```

Or declares an inline function:
```C#
public string GetNameInMessage() => $"Welcome {heldName}. Have a nice day!";
```
Note the () which are required to declare this as a method rather than a property

###Index Initializer
Replaces the old syntax for creating a dictionary:
```C#
var dictionary = new Dictionary
{
  { "001", firstOrder },
  { "002", secondOrder }
}
```
with:
```C#
var dictionary = new Dictionary
{
  ["001"] = firstOrder,
  ["002"] = secondOrder
}
```

###Nameof
Gets the name of a variable as it appears in code:
```C#
public static string GetMessageWithDetailsOfImplementation(string passedMessage)
{
    var nameOfParameter = nameof(passedMessage);
    return $"Value of {nameOfParameter} passed to the method was {passedMessage}";
}
```

###Null Propagation Operator
Operator to coalesce null values in an expression:
```C#
var postcode = lastOrder?.DeliveryAddress?.PostCode
```
All of this will evaluate to null if any property is null


###Static Usings
Usings can be declared as static to reference static properties and methods as though they were in the current class:
```C#
using System.Math;
//---
var pi = Math.Pi;
```
becomes
```C#
using static System.Math;
//---
var pi = Pi;

###String Interpolation
Sematic formatting of strings:
```C#
return $"Hello ${name}, how are you today?"
```
