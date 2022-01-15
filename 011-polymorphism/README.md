---
stack: C#
lang: all
---

## Polymorphism
Polymorphism means “Many Forms”. In Polymorphism, poly means “Many” *and morph means Forms*
Polymorphism is one of the main pillars in Object Oriented Programming.
- overload
- override

## overload
Method Overloading is a type of polymorphism. It has several names like “Compile Time Polymorphism” or “Static Polymorphism” and sometimes it is called “Early Binding”.
 
Method Overloading means creating multiple methods in a class with same names but different signatures (Parameters). It permits a class, struct, or interface to declare multiple methods with the same name with unique signatures.
 
Compiler automatically calls required method to check number of parameters and their type which are passed into that method.

## override
Method Overriding is a type of polymorphism. It has several names like “Run Time Polymorphism” or “Dynamic Polymorphism” and sometime it is called “Late Binding”. 
 
Method Overriding means having two methods with same name and same signatures *parameters*, one should be in the base class and other method should be in a derived class *child class*. You can override the functionality of a base class method to create a same name method with same signature in a derived class. You can achieve method overriding using inheritance. Virtual and Override keywords are used to achieve method overriding.