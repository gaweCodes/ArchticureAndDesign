# Problem
- Large numbers of objects should be supported efficiently.
- Creating large numbers of objects should be avoided.

# Solution
Define Flyweight objects that

store intrinsic (invariant) state that can be shared and
provide an interface through which extrinsic (variant) state can be passed in.
This enables clients to (1) reuse (share) Flyweight objects (instead of creating a new object each time) and (2) pass in extrinsic state when they invoke a Flyweight operation.
This greatly reduces the number of physically created objects.
Intrinsic state is invariant (context independent) and therefore can be shared (for example, the code of character 'A' in a given character set).
Extrinsic state is variant (context dependent) and therefore can not be shared and must be passed in (for example, the position of character 'A' in a text document).

# UML
![Fylweight Uml](Flyweight_UML.png?raw=true "UML")

# Advantages

# Disadvantages