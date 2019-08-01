
namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// This example shows how to use an interface with classes.
    /// The idea behind the interface is to screen the user from how the class works inside.
    /// You should use interfaces wherever possible.  This way you can create substitue test classes and pass them into your routines to ensure they work correctly.
    /// In the case of the .Net generic containers, it allows you to work with things like dictionaries, lists and arrays without having to worry about how they work, just that they will
    /// definitely work in they way described by the interface.
    ///<br></br>
    /// In this example, I have created an interface ICarControls that mimic how you drive a car and then created two car classes, with slightly differnt specificaitons, e.g. a Polo and a Ferrari,
    /// so you can see how an interface contrains the methods and properties that a class that 'implements' the interface must support.
    /// </summary>
    public static class NamespaceDocs
    {
    }
}
