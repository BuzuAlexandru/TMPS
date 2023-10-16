# SOLID Principles


## Author: Buzu Alexandru FAF-212

----

## Objectives:
&ensp; &ensp; __1. Study and understand the SOLID Principles.__

&ensp; &ensp; __2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.__

&ensp; &ensp;__3. Create a sample project that respects SOLID Principles.__

## Theory

* __Single responsibility:__ A class should only have one responsibility and only one reason to change.

* __Open closed principle:__ You should be able to extend your classes without having to modify exiting code to accomodate new one.

* __Liskov substitution:__ All subclasses of class have to implement the methods of the superclass in a way that objects of the subclass should be able to replace objects of the superclass without disrupting the behaviour of the program.

* __Interface segregation:__ Separate interface functionalites so as to not force classes to implement methods they don't need.

* __Dependency inversion:__ Instantiating new objects of some class inside another class tightly couples them together. Thus, to avoid that, classes should communicate through abstractions, by passing object references using dependency injection. 