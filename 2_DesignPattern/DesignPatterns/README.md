# Design Patterns



# 1.Introduction

:pushpin:**How does design pattern help?**

It aims to tackle Déjà Vu which you have solved a problem before but not knowing exactly where or how.

:pushpin:**Purpose of this Book**

The purpose of this book is to record **experience** in designing object-oriented software as **design patterns**.

:pushpin:**Design Pattern in Chinese**

将面向对象编程经验**可复用**的东西抽象成设计模式。

:smile:**Fun Fact**

The design pattern in Software Development actually was affected by an architect Christopher Alexander where he addressed that "*Each pattern describes a problem which occurs over and over again in our environment, and then **describes the core of the solution to that problem**, in such a way that you can **use this solution a million times over**, **without ever doing it the same way** twice*".



## 1.1. What Is a Design Pattern?

:pushpin: **4 essential elements** for a design pattern

- :one:**pattern name**, a handle to **describe** a design problem
- :two:**problem**, elaborate the problem with its context and include **a list of conditions to check** before applying design patterns(see if fits?)
- :three:**solution**
  - :heavy_check_mark:it is **an abstraction and template** to solve such problem(抽象结局方案)
  - :x: it is NOT a particular design or implementation(不具体实现) 
- :four:**consequence**, the result and **trade-off** applying such design pattern



:pushpin:**Design Pattern Definition(.fml)**

The design patterns are *description of communicating objects and classes that are customized to solve a general design problem in a particular context*.



## 1.2. Design Pattern in MVC

In this section, we take MVC as an example to see which kinds of design patterns it applied.

:pushpin:**What is MVC?**

MVC is <u>**Model / View / Controller**</u>.

> ​	The Model is the application object.

> ​	The View is its screen presentation. 

> ​	The Controller defines the way the user interface reacts to user input.

MVC **decouples** <u>views</u> and <u>models</u> by establishing a **subscribe/notify** protocol between them.

:pushpin:**Diagram of application used MVC**

<img src="img/image-20211214162317094.png" alt="image-20211214162317094" style="zoom: 80%;" />

:pushpin:**MVC & MVVM**

A great analogy is MVC and MVVM.

| MVC                                                          | MVVM                                                         |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| An architectural pattern                                     | A software architectural pattern                             |
| Model View Controller                                        | Model View ViewModel                                         |
| Model -> data<br/>View -> user interface<br/>Controller -> handles request | Model -> entities and domain objects<br/>View -> user interface layer<br/>View Model-> describes binding between view and model |
| Used by ASP.NET, Java, Spring                                | Used by Angular JS, Microsoft WPF                            |

From my point of view, the MVVM is a subset or an explicit implementation(实现) of MVC. MVC can be more abstract.



:pushpin:**What kinds of design pattern applied in MVC?**

<u>OBSERVER</u>: 

> ​	the methodology of observer is to **decouple objects** so that changes to one can affect any number of others without requiring the changed object to know details of the others.
>
> ​	e.g. The model and view is separated. If some data is changed in Model, the View can apply the changes to other views.

<u>COMPOSITE</u>:

> ​	the methodology of composite is to "**compose**" objects into **tree structures** to represent part-whole hierarchies.
>
> ​	e.g. create a big class including 
>
> ​			A. subclasses define primitive objects (e.g., Button)
>
> ​			B. other classes define composite objects (CompositeView) that **assemble the primitives into more complex objects**.

<u>STRATEGY</u>:

> ​	the methodology of strategy is to select an algorithm at runtime
>
> ​	e.g. a view can be disabled so that it doesn't accept input simply by giving it a controller that ignores input events.





## 1.3. Describing Design Patterns:star:

The following is a template to describe design patterns in a unique sense.

:pushpin:**Pattern Name and Classification**

> ​	The name is the essence of the pattern.

:pushpin:**Intent**

> ​	A short description what does this pattern do?

:pushpin:**Also Known As**

> ​	Alias for this pattern (if any).

:pushpin:**Motivation**

> ​	A scenario that illustrates a design problem and how the class and object structures in the pattern solve the problem.

:pushpin:**Applicability**

> ​	What are the situations in which the design pattern can be applied?

:pushpin:**Structure**

> ​	A graphical representation of this design pattern.

:pushpin:**Participants**

> ​	The participated classes and/or objects and their responsibility.

:pushpin:**Collaborations**

> ​	How the participants work together?

:pushpin:**Consequences**

> ​	The trade-off and results.

:pushpin:**Implementation(实现)**

> ​	What pitfalls, hints, or techniques should be aware of implementing the pattern?

:pushpin:**Sample Code**

> ​	Code fragments

:pushpin:**Known Issues**

> ​	Examples

:pushpin:**Related Patterns**

> ​	The closest pattern to current one, what are their differences?



## 1.4. The Catalog of Design Patterns:star:

The following is the design patterns. //TODO write with your own words after finished this book,

:pushpin:**Abstract Factory**

> ​	Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

:pushpin:**Adapter**

> ​	Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

:pushpin:**Bridge**

> ​	Decouple an abstraction from its implementation so that the two can vary independently.

:pushpin:**Builder**

> ​	Separate the construction of a complex object from its representation so that the same construction process can create different representations.

:pushpin:**Chain of Responsibility**

> ​	Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

:pushpin:**Command**

> ​	Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

:pushpin:**Composite**

> ​	Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

:pushpin:**Decorator**

> ​	Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

:pushpin:**Facade**

> ​	Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

:pushpin:**Factory Method**

> ​	Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

:pushpin:**Flyweight**

> ​	Use sharing to support large numbers of fine-grained objects efficiently.

:pushpin:**Interpreter**

> ​	Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.

:pushpin:**Iterator**

> ​	Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

:pushpin:**Mediator**

> ​	Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

:pushpin:**Memento**

> ​	Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.

:pushpin:**Observer**

> ​	Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

:pushpin:**Prototype**

> ​	Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

:pushpin:**Proxy**

> ​	Provide a surrogate or placeholder for another object to control access to it.

:pushpin:**Singleton**

> ​	Ensure a class only has one instance, and provide a global point of access to it.

:pushpin:**State **

> ​	Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

:pushpin:**Strategy **

> ​	Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

:pushpin:**Template Method**

> ​	Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

:pushpin:**Visitor **

> ​	Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.



## 1.5. Categorizing Design Patterns:star:

Categorizing the design patterns with certain rules is of tremendous importance. 

There are **2** criteria:

:one:**Purpose**, it reflects what a pattern does

- `creational patterns`, concern the process of object creation.

- `structural patterns`, deals with the composition of classes or objects
- `behavioral patterns`, characterize the interaction and responsibility of classes and objects

:two:**Scope**, it specifies whether the pattern applies to classes or objects

- `class patterns`, deal with relationship between classes and subclasses, they are static - fixed at runtime.
- `object patterns`, deal with object relationship, they are dynamic - changed at runtime.



<img src="img/image-20211216154058477.png" alt="image-20211216154058477" style="zoom: 67%;" />



:pushpin:**How to see these patterns?**

The pattern can be defined as [Purpose]-[Scope]. 



:pushpin:**Example - interpret the pattern**

> ​	<u>Purpose</u> = Structural,

> ​	<u>Scope</u> = Class,

`Structural class` patterns use inheritance to **compose classes**.



> ​	<u>Purpose</u> = Structural,

> ​	<u>Scope</u> = Object,

`Structural object` patterns describe ways to **assemble objects**.



## 1.6. How Design Patterns Solve Design Problem

- `1.6.1.` illustrates what is an object (in abstraction, in configuration)
- `1.6.2.` defines how "abstract" the object is



### 1.6.1. Finding Appropriate Objects

:pushpin:**Why object is important?**

Object-oriented programs are made of objects.



:pushpin:**Insight of object**

In short, object's internal state is said to be **encapsulated**.

![image-20211216171150589](img/image-20211216171150589.png)



:pushpin:**Hard part of OOP**

It is HARD to **decompose a system into objects** in object-oriented design. Why is hard? It MUST take followings into consideration.

- encapsulation
- granularity
- dependency
- flexibility
- performance
- evolution
- reusability



:pushpin:**Design Pattern can help**

Design patterns help you to identify an appropriate object with abstraction.



### 1.6.2. Determining Object Granularity

:pushpin:**What is Granularity?**

Granularity is a level of details(LOD).



:pushpin:**Why Granularity matters?**

It corresponds to memory-consuming. For example, you have the following in your program:

- trees in game landscape
- characters in document
- power points in cad application

If you will create separate object for each tree/character/power-point it could be very memory-consuming. Recall the days I played with Rendering and Forest in 3dsMax.



:pushpin:**Design Pattern can help**

It helps you decide what should be an object(in which level of details).



### 1.6.3. Specifying Object Interfaces

:pushpin:**What is signature?**

The signature is composed of <u>parameters</u> and <u>return types</u>.

```c++
int addOne(int num);
```



:pushpin:**What is interface?**

The **interface is the set of all the signatures defined by an object**. You can say this object supports following interface.



:pushpin:**What is a type?**

A type is a name used to **denote a particular interface**. We speak of an object as having the type "Elephant" if it accepts all requests for the operations defined in the interface named "Elephant".



:pushpin:**What is dynamic binding?**

The run-time association of a request to an object and one of its operations is known as dynamic binding.



:pushpin:**What is polymorphism?**

Dynamic binding lets you substitute objects that have identical interfaces for each other at run-time. This substitutability is known as polymorphism.



:pushpin:**Why polymorphism is important?**

Polymorphism simplifies the definitions of clients, decouples objects from each other, and lets them vary their relationships to each other at run-time. It is a :star:**KEY** concept in OOP.



:pushpin:**Why interface is important?**

You can only achieve polymorphism by interface.



:pushpin:**Design Pattern can help**

:one:Design patterns help you define interfaces by **identifying** their **key elements and the kinds of data** that get sent across an interface.

:two:Design patterns also **specify relationships** between interfaces.



### 1.6.4. Specifying Object Implementation

:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****







:pushpin:****





