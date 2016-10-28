**Structural Patterns Homework**
------------------------------------------------

### **Decorator**
 - **Motivation**
	- As an example, consider a window in a windowing system. To allow scrolling of the window's contents, one may wish to add horizontal or vertical scrollbars to it, as appropriate. Assume windows are represented by instances of the Window class, and assume this class has no functionality for adding scrollbars. One could create a subclass ScrollingWindow that provides them, or create a ScrollingWindowDecorator that adds this functionality to existing Window objects. At this point, either solution would be fine.

        Now, assume one also desires the ability to add borders to windows. Again, the original Window class has no support. The ScrollingWindow subclass now poses a problem, because it has effectively created a new kind of window. If one wishes to add border support to many but not all windows, one must create subclasses WindowWithBorder and ScrollingWindowWithBorder etc. This problem gets worse with every new feature or window subtype to be added. For the decorator solution, we simply create a new BorderedWindowDecorator—at runtime, we can decorate existing windows with the ScrollingWindowDecorator or the BorderedWindowDecorator or both, as we see fit. Notice that if the functionality needs to be added to all Windows, you could modify the base class and that will do. On the other hand, sometimes (e.g., using external frameworks) it is not possible, legal, or convenient to modify the base class.

        Note, in the previous example, that the "SimpleWindow" and "WindowDecorator" classes implement the "Window" interface, which defines the "draw()" method and the "getDescription()" method, that are required in this scenario, in order to decorate a window control.
 - **Intent**
 	- The decorator pattern can be used to extend (decorate) the functionality of a certain object statically, or in some cases at run-time, independently of other instances of the same class, provided some groundwork is done at design time. This is achieved by designing a new Decorator class that wraps the original class.
 - **Applicability**
    - Use Decorator:
        - to add responsibilities to individual objects dynamically and transparently, that is, without affecting other objects.
        - for responsibilities that can be withdrawn.
        - when extension by subclassing is impractical. Sometimes a large number of independent extensions are possible and would produce an explosion of subclasses to support every combination. Or a class definition may be hidden or otherwise unavailable for subclassing.

 - **Known uses**
    - Many object-oriented user interface toolkits use decorators to add graphical embellishments to widgets. Examples include InterViews, ET++, and the ObjectWorks\Smalltalk class library. More exotic applications of Decorator are the DebuggingGlyph from InterViews and the PassivityWrapper from ParcPlace Smalltalk. A DebuggingGlyph prints out debugging information before and after it forwards a layout request to its component. This trace information can be used to analyze and debug the layout behavior of objects in a complex composition. The PassivityWrapper can enable or disable user interactions with the component.

 - **Implementation**


```cs
using System;

namespace DoFactory.GangOfFour.Decorator.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Decorator Design Pattern.
    /// </summary>
    class MainApp
    {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create ConcreteComponent and two Decorators
      ConcreteComponent c = new ConcreteComponent();
      ConcreteDecoratorA d1 = new ConcreteDecoratorA();
      ConcreteDecoratorB d2 = new ConcreteDecoratorB();

      // Link decorators
      d1.SetComponent(c);
      d2.SetComponent(d1);

      d2.Operation();

      // Wait for user
      Console.ReadKey();
    }
    }

    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class Component
    {
    public abstract void Operation();
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class ConcreteComponent : Component
    {
    public override void Operation()
    {
      Console.WriteLine("ConcreteComponent.Operation()");
    }
    }

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator : Component
    {
    protected Component component;

    public void SetComponent(Component component)
    {
      this.component = component;
    }

    public override void Operation()
    {
      if (component != null)
      {
        component.Operation();
      }
    }
    }

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    class ConcreteDecoratorA : Decorator
    {
    public override void Operation()
    {
      base.Operation();
      Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
    }

    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    class ConcreteDecoratorB : Decorator
    {
    public override void Operation()
    {
      base.Operation();
      AddedBehavior();
      Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
    }
    }
}

```


 - **Consequences**
    - The Decorator pattern has at least two key benefits and two liabilities:
        - More flexibility than static inheritance.
        - Avoids feature-laden classes high up in the hierarchy.
        - A decorator and its component aren't identical.
        - Lots of little objects.
 - **Structure**

![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Decorator__1.svg)


### **Adapter**
 - **Motivation**

    Reuse has always been painful and elusive. One reason has been the tribulation of designing something new, while reusing something old. There is always something not quite right between the old and the new. It may be physical dimensions or misalignment. It may be timing or synchronization. It may be unfortunate assumptions or competing standards.

    It is like the problem of inserting a new three-prong electrical plug in an old two-prong wall outlet – some kind of adapter or intermediary is necessary.

    Adapter real example

    Adapter is about creating an intermediary abstraction that translates, or maps, the old component to the new system. Clients call methods on the Adapter object which redirects them into calls to the legacy component. This strategy can be implemented either with inheritance or with aggregation.

    Adapter functions as a wrapper or modifier of an existing class. It provides a different or translated view of that class.
 - **Intent**

    Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
 - **Applicability**

    Use the Adapter pattern when:
    - you want to use an existing class, and its interface does not match the one you need.
    - you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.
    - (object adapter only) you need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class.


 - **Implementation**

```cs
using System;

namespace DoFactory.GangOfFour.Adapter.Structural
{
/// <summary>
/// MainApp startup class for Structural
/// Adapter Design Pattern.
/// </summary>
    class MainApp
    {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create adapter and place a request
      Target target = new Adapter();
      target.Request();

      // Wait for user
      Console.ReadKey();
    }
    }

    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Target
    {
        public virtual void Request()
        {
          Console.WriteLine("Called Target Request()");
        }
    }

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
          // Possibly do some other work
          //  and then call SpecificRequest
          _adaptee.SpecificRequest();
        }
    }

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class Adaptee
    {
        public void SpecificRequest()
        {
          Console.WriteLine("Called SpecificRequest()");
        }
    }
}
```

- **Consequences**

    Class and object adapters have different trade-offs. A class adapter:
    - adapts Adaptee to Target by committing to a concrete Adapter class. As a consequence, a class adapter won't work when we want to adapt a class and all its subclasses.
    - lets Adapter override some of Adaptee's behavior, since Adapter is a subclass of Adaptee.
    - introduces only one object, and no additional pointer indirection is needed to get to the adaptee.

    An object adapter:
    - lets a single Adapter work with many Adaptees---that is, the Adaptee itself and all of its subclasses (if any). The Adapter can also add functionality to all Adaptees at once.
    - makes it harder to override Adaptee behavior. It will require subclassing Adaptee and making Adapter refer to the subclass rather than the Adaptee itself.
 - **Structure**

    ![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Adapter_1.svg)

### **Proxy**

 - **Motivation**
    	-
 - **Intent**
     - Provide a surrogate or placeholder for another object to control access to it.
    - Use an extra level of indirection to support distributed, controlled, or intelligent access.
    - Add a wrapper and delegation to protect the real component from undue complexity.
 - **Applicability**
    - Remote Proxy
        - In distributed object communication, a local object represents a remote object (one that belongs to a different address space). The local object is a proxy for the remote object, and method invocation on the local object results in remote method invocation on the remote object. An example would be an ATM implementation, where the ATM might hold proxy objects for bank information that exists in the remote server.

    - Virtual Proxy
        - In place of a complex or heavy object, a skeleton representation may be advantageous in some cases. When an underlying image is huge in size, it may be represented using a virtual proxy object, loading the real object on demand.

    - Protection Proxy
        - A protection proxy might be used to control access to a resource based on access rights.

 - **Known uses**
        -

 - **Implementation**


```cs   
using System;

namespace DoFactory.GangOfFour.Proxy.Structural
    {
        /// <summary>
        /// MainApp startup class for Structural
        /// Proxy Design Pattern.
        /// </summary>
        class MainApp
        {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
            static void Main()
            {
              // Create proxy and request a service
              Proxy proxy = new Proxy();
              proxy.Request();

              // Wait for user
              Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Subject' abstract class
        /// </summary>
        abstract class Subject
        {
            public abstract void Request();
        }

        /// <summary>
        /// The 'RealSubject' class
        /// </summary>
        class RealSubject : Subject
        {
            public override void Request()
            {
              Console.WriteLine("Called RealSubject.Request()");
            }
        }

        /// <summary>
        /// The 'Proxy' class
        /// </summary>
        class Proxy : Subject
        {
            private RealSubject _realSubject;

            public override void Request()
            {
              // Use 'lazy initialization'
              if (_realSubject == null)
              {
                _realSubject = new RealSubject();
              }

              _realSubject.Request();
            }
        }
    }
```


 - **Consequences**
    - You need to support resource-hungry objects, and you do not want to instantiate such objects unless and until they are actually requested by the client.
 - **Structure**

    ![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Proxy1.svg)
