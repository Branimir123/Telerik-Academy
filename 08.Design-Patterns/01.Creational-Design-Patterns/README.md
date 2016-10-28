**Creational Patterns Homework**
------------------------------------------------

### **Abstract Factory**
 - **Motivation**
	- Modularization is a big issue in today's programming. Programmers all over the world are trying to avoid the idea of adding code to existing classes in order to make them support encapsulating more general information.
 - **Intent**
 	- Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
	- A hierarchy that encapsulates: many possible "platforms", and the construction of a suite of "products".
	- The new operator considered harmful
 - **Applicability**

     We should use the Abstract Factory design pattern when:
     - the system needs to be independent from the way the products it works with are created.
     - the system is or should be configured to work with multiple families of products.
     - a family of products is designed to work only all together.
     - the creation of a library of products is needed, for which is relevant only the interface, not the implementation, too.
 - **Known uses**
	 - If an application is to be portable, it needs to encapsulate platform dependencies. These "platforms" might include: windowing system, operating system, database, etc. Too often, this encapsulation is not engineered in advance, and lots of #ifdef case statements with options for all currently supported platforms begin to procreate like rabbits throughout the code.

 - **Implementation**


```cs
interface IButton
{
    void Paint();
}

interface IGUIFactory
{
    IButton CreateButton();
}

class WinFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }
}

class OSXFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new OSXButton();
    }
}

class WinButton : IButton
{
    public void Paint()
    {
        //Render a button in a Windows style
    }
}

class OSXButton : IButton
{
    public void Paint()
    {
        //Render a button in a Mac OS X style
    }
}

class Program
{
    static void Main()
    {
        var appearance = Settings.Appearance;

        IGUIFactory factory;
        switch (appearance)
        {
            case Appearance.Win:
                factory = new WinFactory();
                break;
            case Appearance.OSX:
                factory = new OSXFactory();
                break;
            default:
                throw new System.NotImplementedException();
        }

        var button = factory.CreateButton();
        button.Paint();
    }
}
```


 - **Consequences**
	 - It isolates concrete classes. The Abstract Factory pattern helps you control the classes of objects that an application creates. Because a factory encapsulates the responsibility and the process of creating product objects, it isolates clients from implementation classes. Clients manipulate instances through their abstract interfaces. Product class names are isolated in the implementation of the concrete factory; they do not appear in client code.
	 - It makes exchanging product families easy. The class of a concrete factory appears only once in an application---that is, where it's instantiated. This makes it easy to change the concrete factory an application uses. It can use different product configurations simply by changing the concrete factory. Because an abstract factory creates a complete family of products, the whole product family changes at once. In our user interface example, we can switch from Motif widgets to Presentation Manager widgets simply by switching the corresponding factory objects and recreating the interface.
	 - It promotes consistency among products. When product objects in a family are designed to work together, it's important that an application use objects from only one family at a time. AbstractFactory makes this easy to enforce.
	 - Supporting new kinds of products is difficult. Extending abstract factories to produce new kinds of Products isn't easy. That's because the AbstractFactory interface fixes the set of products that can be created. Supporting new kinds of products requires extending the factory interface, which involves changing the AbstractFactory class and all of its subclasses. We discuss one solution to this problem in the Implementation section.

 - **Structure**

![Structure of abstract factory](https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Abstract_factory_UML.svg/2000px-Abstract_factory_UML.svg.png)

 - **Related patterns**
	 - AbstractFactory classes are often implemented with factory methods, but they can also be implemented using Prototype. A concrete factory is often a singleton.

 ##**Singleton**

- **Motivation**
    - Sometimes it's important to have only one instance for a class. For example, in a system there should be only one window manager (or only a file system or only a print spooler). Usually singletons are used for centralized management of internal or external resources and they provide a global point of access to themselves.

    - The singleton pattern is one of the simplest design patterns: it involves only one class which is responsible to instantiate itself, to make sure it creates not more than one instance; in the same time it provides a global point of access to that instance. In this case the same instance can be used from everywhere, being impossible to invoke directly the constructor each time.

 - **Intent**
    - Ensure that only one instance of a class is created.
Provide a global point of access to the object.

 - **Applicability**
    - The Singleton pattern has two primary criteria for applicability:
        - The class should have exactly one instance which should be accessible from a method in the class.
        - The class can be subclassed, and clients can use the subclass as an instance of the superclass without having to change any code.
        The first criterion more or less defines the nature of the Singleton pattern.
        The second criterion considers issues of reuse. In many cases there is more than one way to solve the immediate problem.
 - **Known uses**
     - The abstract factory, builder, and prototype patterns can use Singletons in their implementation.
     - Facade objects are often singletons because only one Facade object is required.
     - State objects are often singletons.
     - Singletons are often preferred to global variables because:
        - They do not pollute the global namespace (or, in languages with namespaces, their containing namespace) with unnecessary variables.
        - They permit lazy allocation and initialization, whereas global variables in many languages will always consume resources.

  - **Implementation**

    ```cs
     using System;

     namespace DoFactory.GangOfFour.Singleton.Structural
     {
         /// <summary>
          /// MainApp startup class for Structural
          /// Singleton Design Pattern.
          /// </summary>
          class MainApp
          {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
          // Constructor is protected -- cannot use new
          Singleton s1 = Singleton.Instance();
          Singleton s2 = Singleton.Instance();

          // Test for same instance
          if (s1 == s2)
          {
            Console.WriteLine("Objects are the same instance");
          }

          // Wait for user
          Console.ReadKey();
        }
      }

      /// <summary>
      /// The 'Singleton' class
      /// </summary>
      class Singleton
      {
        private static Singleton _instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
          // Uses lazy initialization.
          // Note: this is not thread safe.
          if (_instance == null)
          {
            _instance = new Singleton();
          }

          return _instance;
        }
    }
```


  - **Consequences**
    - ***Controls access***
      - The Singleton class can easily control who accesses its single instance and how. The getInstance() method can keep track of how many classes have "checked out" the instance. It can queue requests. It can verify the state of the system before returning.
Primarily, this is a consequence of making the instance field non-public and passing all access through the getInstance() method.
This consequence is far from unique to the Singleton pattern. Almost all well-designed classes have this characteristic.

     - ***Permits subclassing***
         - The Singleton class can be subclassed. Subclasses can return an object that behaves differently than originally intended. This allows client applications to be configured at runtime by selecting a different subclass.
     - ***Enhances flexibility***
         - An alternative to the Singleton class would be to create a class with only static members . Since static members have only one value per class, the immediate effect would be similar.
        However, pure static members do not lend themselves to subclassing.
        Furthermore, it is often easier to work with instance methods and fields when the same object must be used in different objects at the same time.

- **Structure**

     ![Structure of singleton factory](https://sourcemaking.com/files/v2/content/patterns/singleton1.svg)

  - **Related patterns**
    - Abstract factory
    - Builder
    - Prototype
    - Facade

##**Prototype**

- **Motivation**
    - Today’s programming is all about costs. Saving is a big issue when it comes to using computer resources, so programmers are doing their best to find ways of improving the performance When we talk about object creation we can find a better way to have new objects: cloning. To this idea one particular design pattern is related: rather than creation it uses cloning. If the cost of creating a new object is large and creation is resource intensive, we clone the object.

    - The Prototype design pattern is the one in question. It allows an object to create customized objects without knowing their class or any details of how to create them. Up to this point it sounds a lot like the Factory Method pattern, the difference being the fact that for the Factory the palette of prototypical objects never contains more than one object.

- **Intent**
    - Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
    - Co-opt one instance of a class for use as a breeder of all future instances.
    - The new operator considered harmful.

- **Applicability**
- Use Prototype Pattern when a system should be independent of how its products are created, composed, and represented, and:

    - Classes to be instantiated are specified at run-time
    - Avoiding the creation of a factory hierarchy is needed
    - It is more convenient to copy an existing instance than to create a new one.

- **Implementation**

    ```cs
        public abstract class Prototype
        {
            // normal implementation
            public abstract Prototype Clone();
        }

        public class ConcretePrototype1 : Prototype
        {
            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
            }
        }

        public class ConcretePrototype2 : Prototype
        {
            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
            }
        }
    ```

 - **Structure**
    ![Structure of singleton factory](https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Prototype_UML.svg/678px-Prototype_UML.svg.png)

     - **Related patterns**
