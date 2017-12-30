# Design Patterns

## General
Reusable pattern for solving a problem. Revolves around relationships and interactions between
classes or objects. Idea is to speed up development by using a proven pattern.

Types of Design Patterns:
* Creational
  * Factory, Singleton, Object Pool
* Structural:
  * Adapter, Bridge, Private Class
* Behavioral
  * Interpreter, Iterator, Observer, State

### Factory Method
Idea is to create a static method function that which creates and returns instances hiding the 
details of class creation from the user. See Matrix Class [here.](https://github.com/SHEFFcode/GeeksForGeeksJS/blob/master/DynamicProgramming/AdvancedDataStructures.js)

You can see in the above example that we do not have how big the matrix has to be, whether it is a
two by two or three by three we don't care. We provide the dimentions to the static method, and we
get back a matrix that matches the spec.

### Observer Pattern
Observer pattern is used when there is a single publisher of events, and a lot of subscribers to 
that once change. 

A great example would be react. In react as state updates, a bunch of observers or reducers get
notified of the change, and then they decide what to do with this change, if anything.

Observers themselves don't have access to data, but depend on someone else to provide it.

Advantages:
* Provides for loosely coupled applications
* Loosely coupled objects are more flexible when it comes to business requirements

Disadvantages:
* We can have memory leaks caused by the lapsed listener problem.

### Singleton Pattern
Used when we only want a single instance of something. For example you want to instanciate a click
listener in your application, but at the same time you want to make sure it is present at crucial
stages.  So you call create in the application's crucial junctures, and since you are using a 
singleton, the object will either be created, or nothing bad (like a second click listener) will 
happen.

### Decorator Pattern
Allows you to modify the object dynamically at runtime.  It is more flexible than inheritance, you
end up using many many simple classes.

Rathern than rewriting the old code, you will extend it and keep the old code as it was.

Pizza Shop:
You want to add a bunch of toppings with different prices and come up with a cost.

Utalizes an abstract ToppingDecorator class which contains a concreate basic pizza class made from
basic pizza interface. From this ToppingDecorator class which we can make concrete topping classes.

In the end you get the following call: 
```
Pizza TomatoMozPizza = new TomatoSauce(new Mozzarella(new PlainPizza));
```
Where each new layer overrides and appends to the getType and getCost methods on the plain pizza.

### Iterator Pattern
Something that is used in most data structures. You need some sort of an iterator which will provide
a next() method which will either get you the next item in the strucutre or have some sort of a way 
to spot iteration.

### State Machine Pattern
We have verious states that the class can be in, and each one of the states can perform certain
actions.  This relies on composition where each gumball machine has a list of states, and each state
is passed a specific gumball machine at instanciation.  Each of gumball machine's actions are 
mirrored in the state as appropriate for that state.

When a function on the gumball machine gets called it gets passed along to the state, which has its
own implementation of that method, which gets called by delegation.

When a method gets performed, the state machine can transition to some other state to handle what
ever the next operation is coming.

This way more states can be added without making changes to the overall structure of the gumball
machine class.


## Links
* https://www.youtube.com/watch?v=j40kRwSm4VE - helloInternet! Decorator Pattern
* https://www.youtube.com/watch?v=KmAyPUv9gOY - Design Twitter
* https://www.youtube.com/watch?v=J3DY3Te3A_A - Design Lyft
* https://www.youtube.com/watch?v=fMZMm_0ZhK4 - Design TinyURL
* https://www.youtube.com/watch?v=UzLMhqg3_Wc - Design Interview