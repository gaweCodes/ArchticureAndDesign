# Problem
How can you efficiently describe large composite objects using elementary objects?

# Solution
Define an abstract and narrow interface that is implemented by a concrete lightweight object and by the normal object.

A factory creates and manages all flyweights. This means that only the necessary objects are created when required.

# UML
![Fylweight Uml](Flyweight_UML.png?raw=true "UML")

# Advantages
The process reduces storage costs in proportion to the size of the outsourced state and the number of fly weights. Storage costs continue to decrease if the outsourced state does not have to be saved but can be calculated.

# Disadvantages
The complexity increases relatively strongly, especially for designs that use flyweight together with composite. A clean documentation of the responsibilities is a must. The runtime costs may increase because the outsourced condition must be found again and transferred to the fly weight when the method is called. They continue to rise when the condition is calculated.