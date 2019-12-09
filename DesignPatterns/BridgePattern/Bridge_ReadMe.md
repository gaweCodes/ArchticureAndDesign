# Bridge
Decouple an abstraction from its implementation so that the two can vary independently.

# Problem
An abstraction and its implementation should be defined and extended independently from each other.
A compile-time binding between an abstraction and its implementation should be avoided so that an implementation can be selected at run-time.

# Solution
Separate an abstraction (Abstraction) from its implementation (Implementor) by putting them in separate class hierarchies.
Implement the Abstraction in terms of (by delegating to) an Implementor object.

# UML
![Bridge Uml](Bridge_UML.png?raw=true "UML")


# Advantages

# Disadvantages

# Examples