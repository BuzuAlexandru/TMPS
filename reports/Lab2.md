# Creational Design Patterns


## Author: Buzu Alexandru FAF-212

----

## Objectives:
&ensp; &ensp; __1. Study and understand the Creational Design Patterns.__

&ensp; &ensp; __2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.__

&ensp; &ensp; __3. Use some creational design patterns for object instantiation in a sample project.__


## Used Design Patterns: 

* Singleton
* Abstract factory
* Builder
* Prototype

## Usage

### Singleton
A design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

Made thread-safe using a static constructor, which ensures the object is instantiated only once during runtime.

Saves memory because object is not created at each request. Only single instance is reused again and again.

Mostly used in multi-threaded and database applications. It is used in logging, caching, thread pools, configuration settings etc.

### Abstract factory
Design pattern that lets you produce families of related objects without specifying their concrete classes.

Eases the exchanging of object families.
When the family of related objects has to be used together, then this constraint needs to be enforced.

### Builder
Design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

Encapsulates creating and assembling the parts of a complex object. Provides clear separation between the construction and representation of an object

### Prototype
Design pattern that lets you copy existing objects without making your code dependent on their classes.

The Prototype pattern delegates the cloning process to the actual objects that are being cloned. The pattern declares a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object.

Useful when the cost of creating an object is expensive or complicated.