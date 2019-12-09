# Problem
- The access to an object should be controlled.
- Additional functionality should be provided when accessing an object.
When accessing sensitive objects, for example, it should be possible to check that clients have the needed access rights.

# Solution
Define a separate Proxy object that
- can be used as substitute for another object (Subject) and
- implements additional functionality to control the access to this subject.
This enables to work through a Proxy object to perform additional functionality when accessing a subject. For example, to check the access rights of clients accessing a sensitive object.

To act as substitute for a subject, a proxy must implement the Subject interface. Clients can't tell whether they work with a subject or its proxy.

# UML
![Proxy Uml](Proxy_UML.png?raw=true "UML")

# Advantages

# Disadvantages