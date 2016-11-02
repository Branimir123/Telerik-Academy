**Behavioral Patterns Homework**
------------------------------------------------

### **Strategy**
 - **Motivation**
    - There are common situations when classes differ only in their behavior. For this cases is a good idea to isolate the algorithms in separate classes in order to have the ability to select different algorithms at runtime.
 - **Intent**
 	- Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.
    - Capture the abstraction in an interface, bury implementation details in derived classes.
 - **Applicability**
    - Use the Strategy pattern when:
        - Many related classes differ only in their behavior. Strategies provide a way to configure a class with one of many behaviors.

        - You need different variants of an algorithm. For example, you might define algorithms reflecting different space/time trade-offs. Strategies can be used when these variants are implemented as a class hierarchy of algorithms

        - An algorithm uses data that clients shouldn't know about. Use the Strategy pattern to avoid exposing complex, algorithm-specific data structures.

        - A class defines many behaviors, and these appear as multiple conditional statements in its operations. Instead of many conditionals, move related conditional branches into their own Strategy class.

 - **Implementation**


```cs

using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Strategy Design Pattern.
    /// </summary>
    class MainApp
    {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
        static void Main()
        {
          // Two contexts following different strategies
          SortedList studentRecords = new SortedList();

          studentRecords.Add("Samual");
          studentRecords.Add("Jimmy");
          studentRecords.Add("Sandra");
          studentRecords.Add("Vivek");
          studentRecords.Add("Anna");

          studentRecords.SetSortStrategy(new QuickSort());
          studentRecords.Sort();

          studentRecords.SetSortStrategy(new ShellSort());
          studentRecords.Sort();

          studentRecords.SetSortStrategy(new MergeSort());
          studentRecords.Sort();

          // Wait for user
          Console.ReadKey();
        }
    }

    /// <summary>
/// The 'Strategy' abstract class
/// </summary>
abstract class SortStrategy
{
    public abstract void Sort(List<string> list);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
          list.Sort(); // Default is Quicksort
          Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
          //list.ShellSort(); not-implemented
          Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
          //list.MergeSort(); not-implemented
          Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
          this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
          _list.Add(name);
        }

        public void Sort()
        {
          _sortstrategy.Sort(_list);

          // Iterate over list and display results
          foreach (string name in _list)
          {
            Console.WriteLine(" " + name);
          }
          Console.WriteLine();
        }
    }
}

```


 - **Consequences**

    The Strategy pattern has the following benefits and drawbacks:

    1. Families of related algorithms. Hierarchies of Strategy classes define a family of algorithms or behaviors for contexts to reuse. Inheritance can help factor out common functionality of the algorithms.

    2. An alternative to subclassing. Inheritance offers another way to support a variety of algorithms or behaviors. You can subclass a Context class directly to give it different behaviors. But this hard-wires the behavior into Context. It mixes the algorithm implementation with Context's, making Context harder to understand, maintain, and extend. And you can't vary the algorithm dynamically. You wind up with many related classes whose only difference is the algorithm or behavior they employ. Encapsulating the algorithm in separate Strategy classes lets you vary the algorithm independently of its context, making it easier to switch, understand, and extend.

    3. Strategies eliminate conditional statements. The Strategy pattern offers an alternative to conditional statements for selecting desired behavior. When different behaviors are lumped into one class, it's hard to avoid using conditional statements to select the right behavior. Encapsulating the behavior in separate Strategy classes eliminates these conditional statements.

    4. A choice of implementations. Strategies can provide different implementations of the same behavior. The client can choose among strategies with different time and space trade-offs.

    5. Clients must be aware of different Strategies. The pattern has a potential drawback in that a client must understand how Strategies differ before it can select the appropriate one. Clients might be exposed to implementation issues. Therefore you should use the Strategy pattern only when the variation in behavior is relevant to clients.

    6. Communication overhead between Strategy and Context. The Strategy interface is shared by all ConcreteStrategy classes whether the algorithms they implement are trivial or complex. Hence it's likely that some ConcreteStrategies won't use all the information passed to them through this interface; simple ConcreteStrategies may use none of it! That means there will be times when the context creates and initializes parameters that never get used. If this is an issue, then you'll need tighter coupling between Strategy and Context.

    7. Increased number of objects. Strategies increase the number of objects in an application. Sometimes you can reduce this overhead by implementing strategies as stateless objects that contexts can share. Any residual state is maintained by the context, which passes it in each request to the Strategy object. Shared strategies should not maintain state across invocations. The Flyweight pattern describes this approach in more detail.


 - **Structure**

![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Strategy_.svg)


### **Memento**
 - **Motivation**

    Sometimes it's necessary to record the internal state of an object. This is required when implementing checkpoints and undo mechanisms that let users back out of tentative operations or recover from errors. You must save state information somewhere so that you can restore objects to their previous states. But objects normally encapsulate some or all of their state, making it inaccessible to other objects and impossible to save externally. Exposing this state would violate encapsulation, which can compromise the application's reliability and extensibility.

 - **Intent**
     - Without violating encapsulation, capture and externalize an object's internal state so that the object can be returned to this state later.
     - A magic cookie that encapsulates a "check point" capability.
     Promote undo or rollback to full object status.

 - **Applicability**

    Use the Memento pattern when:

    - a snapshot of (some portion of) an object's state must be saved so that it can be restored to that state later, and
    - a direct interface to obtaining the state would expose implementation details and break the object's encapsulation.


 - **Implementation**


```cs
using System;

namespace DoFactory.GangOfFour.Memento.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Memento Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
          Originator o = new Originator();
          o.State = "On";

          // Store internal state
          Caretaker c = new Caretaker();
          c.Memento = o.CreateMemento();

          // Continue changing originator
          o.State = "Off";

          // Restore saved state
          o.SetMemento(c.Memento);

          // Wait for user
          Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    class Originator
        {
        private string _state;

        // Property
        public string State
        {
          get { return _state; }
          set
          {
            _state = value;
            Console.WriteLine("State = " + _state);
          }
        }

        // Creates memento
        public Memento CreateMemento()
        {
          return (new Memento(_state));
        }

        // Restores original state
        public void SetMemento(Memento memento)
        {
          Console.WriteLine("Restoring state...");
          State = memento.State;
        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class Memento
    {
        private string _state;

        // Constructor
        public Memento(string state)
        {
          this._state = state;
        }

        // Gets or sets state
        public string State
        {
          get { return _state; }
        }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class Caretaker
    {
        private Memento _memento;

        // Gets or sets memento
        public Memento Memento
        {
          set { _memento = value; }
          get { return _memento; }
        }
    }
}


```


 - **Consequences**

    The Memento pattern has several consequences:

    - Preserving encapsulation boundaries. Memento avoids exposing information that only an originator should manage but that must be stored nevertheless outside the originator. The pattern shields other objects from potentially complex Originator internals, thereby preserving encapsulation boundaries.
    - It simplifies Originator. In other encapsulation-preserving designs, Originator keeps the versions of internal state that clients have requested. That puts all the storage management burden on Originator. Having clients manage the state they ask for simplifies Originator and keeps clients from having to notify originators when they're done.
    - Using mementos might be expensive. Mementos might incur considerable overhead if Originator must copy large amounts of information to store in the memento or if clients create and return mementos to the originator often enough. Unless encapsulating and restoring Originator state is cheap, the pattern might not be appropriate. See the discussion of incrementality in the Implementation section.
    - Defining narrow and wide interfaces. It may be difficult in some languages to ensure that only the originator can access the memento's state.
    - Hidden costs in caring for mementos. A caretaker is responsible for deleting the mementos it cares for. However, the caretaker has no idea how much state is in the memento. Hence an otherwise lightweight caretaker might incur large storage costs when it stores mementos.

 - **Structure**

![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Memento.svg)


### **Visitor**
 - **Motivation**


 - **Intent**

    Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.



 - **Applicability**

    Use the Visitor pattern when:

    - an object structure contains many classes of objects with differing interfaces, and you want to perform operations on these objects that depend on their concrete classes.
    - many distinct and unrelated operations need to be performed on objects in an object structure, and you want to avoid "polluting" their classes with these operations. Visitor lets you keep related operations together by defining them in one class. When the object structure is shared by many applications, use Visitor to put operations in just those applications that need them.
    - the classes defining the object structure rarely change, but you often want to define new operations over the structure. Changing the object structure classes requires redefining the interface to all visitors, which is potentially costly. If the object structure classes change often, then it's probably better to define the operations in those classes.


 - **Implementation**


```cs
using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Visitor.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Visitor Design Pattern.
    /// </summary>
    class MainApp
    {
    static void Main()
    {
      // Setup structure
      ObjectStructure o = new ObjectStructure();
      o.Attach(new ConcreteElementA());
      o.Attach(new ConcreteElementB());

      // Create visitor objects
      ConcreteVisitor1 v1 = new ConcreteVisitor1();
      ConcreteVisitor2 v2 = new ConcreteVisitor2();

      // Structure accepting visitors
      o.Accept(v1);
      o.Accept(v2);

      // Wait for user
      Console.ReadKey();
    }
    }

    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    abstract class Visitor
    {
    public abstract void VisitConcreteElementA(
      ConcreteElementA concreteElementA);
    public abstract void VisitConcreteElementB(
      ConcreteElementB concreteElementB);
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class ConcreteVisitor1 : Visitor
    {
    public override void VisitConcreteElementA(
      ConcreteElementA concreteElementA)
    {
      Console.WriteLine("{0} visited by {1}",
        concreteElementA.GetType().Name, this.GetType().Name);
    }

    public override void VisitConcreteElementB(
      ConcreteElementB concreteElementB)
    {
      Console.WriteLine("{0} visited by {1}",
        concreteElementB.GetType().Name, this.GetType().Name);
    }
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class ConcreteVisitor2 : Visitor
    {
    public override void VisitConcreteElementA(
      ConcreteElementA concreteElementA)
    {
      Console.WriteLine("{0} visited by {1}",
        concreteElementA.GetType().Name, this.GetType().Name);
    }

    public override void VisitConcreteElementB(
      ConcreteElementB concreteElementB)
    {
      Console.WriteLine("{0} visited by {1}",
        concreteElementB.GetType().Name, this.GetType().Name);
    }
    }

    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
    public abstract void Accept(Visitor visitor);
    }

    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    class ConcreteElementA : Element
    {
    public override void Accept(Visitor visitor)
    {
      visitor.VisitConcreteElementA(this);
    }

    public void OperationA()
    {
    }
    }

    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    class ConcreteElementB : Element
    {
    public override void Accept(Visitor visitor)
    {
      visitor.VisitConcreteElementB(this);
    }

    public void OperationB()
    {
    }
    }

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class ObjectStructure
    {
    private List<Element> _elements = new List<Element>();

    public void Attach(Element element)
    {
      _elements.Add(element);
    }

    public void Detach(Element element)
    {
      _elements.Remove(element);
    }

    public void Accept(Visitor visitor)
    {
      foreach (Element element in _elements)
      {
        element.Accept(visitor);
      }
    }
    }
}


```


 - **Consequences**

    Some of the benefits and liabilities of the Visitor pattern are as follows:

    1. Visitor makes adding new operations easy. Visitors make it easy to add operations that depend on the components of complex objects. You can define a new operation over an object structure simply by adding a new visitor. In contrast, if you spread functionality over many classes, then you must change each class to define a new operation.
    2. A visitor gathers related operations and separates unrelated ones. Related behavior isn't spread over the classes defining the object structure; it's localized in a visitor. Unrelated sets of behavior are partitioned in their own visitor subclasses. That simplifies both the classes defining the elements and the algorithms defined in the visitors. Any algorithm-specific data structures can be hidden in the visitor.
    3. Adding new ConcreteElement classes is hard. The Visitor pattern makes it hard to add new subclasses of Element. Each new ConcreteElement gives rise to a new abstract operation on Visitor and a corresponding implementation in every ConcreteVisitor class. Sometimes a default implementation can be provided in Visitor that can be inherited by most of the ConcreteVisitors, but this is the exception rather than the rule.
    So the key consideration in applying the Visitor pattern is whether you are mostly likely to change the algorithm applied over an object structure or the classes of objects that make up the structure. The Visitor class hierarchy can be difficult to maintain when new ConcreteElement classes are added frequently. In such cases, it's probably easier just to define operations on the classes that make up the structure. If the Element class hierarchy is stable, but you are continually adding operations or changing algorithms, then the Visitor pattern will help you manage the changes.

    4. Visiting across class hierarchies. An iterator can visit the objects in a structure as it traverses them by calling their operations. But an iterator can't work across object structures with different types of elements.

    5. Accumulating state. Visitors can accumulate state as they visit each element in the object structure. Without a visitor, this state would be passed as extra arguments to the operations that perform the traversal, or they might appear as global variables.

    6. Breaking encapsulation. Visitor's approach assumes that the ConcreteElement interface is powerful enough to let visitors do their job. As a result, the pattern often forces you to provide public operations that access an element's internal state, which may compromise its encapsulation.


 - **Structure**

![Structure of abstract factory](https://sourcemaking.com/files/v2/content/patterns/Visitor1.svg)
