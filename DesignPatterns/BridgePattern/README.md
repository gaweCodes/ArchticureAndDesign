# Problem
How can you implement an abstraction without including inheritance in the abstraction as well as in the implementation.

# Solution
If the abstract classes and the implementations are managed in two different hierarchies, firstly the clarity gains and secondly the application becomes independent of the implementation.

# UML
![Bridge Uml](Bridge_UML.png?raw=true "UML")

# Advantages
*Abstraction and implementation are decoupled.
*The implementation can be changed dynamically during runtime.
*The extensibility of abstraction and implementation is improved.
*The implementation can be selected by specifying a parameter when generating an abstraction.
*The implementation is completely hidden from the client.
*Avoid a large increase in the number of classes.

# Disadvantages
*No implementation of functionality allowed in abstract classes