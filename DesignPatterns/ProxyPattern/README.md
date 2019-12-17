# Problem
How can an object be accessed which with special preconditions and connections?

# Solution
Define an interface and implement both the real and the proxy object. However, the real object should only be accessed via the proxy.

# UML
![Proxy Uml](Proxy_UML.png?raw=true "UML")

# Advantages
*Proxies can control access to objects before delegating method calls to the subject
*The client does not notice the control of the object
*Proxies also work if the actual object is not yet available in memory (e.g. lazy loading)
*Proxies can help to increase the speed of the application (e.g. caching)
*Proxies can enable interprocess communication / remote communication between objects

# Disadvantages
*Depending on the implementation, proxies can delay the response time
**Proxies add another layer of abstraction, which can lead to detours and increase complexity
*All methods defined by the interface for the proxy must be created and delegated to the subject