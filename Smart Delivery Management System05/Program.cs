namespace Smart_Delivery_Management_System05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 — Theoretical Questions


            #region Question01

            //a) What happens when you assign one object variable to another object variable?
            //Answer:The object variable copies the reference of the other object variable, and both variables point to the same object in the heap.

            //b) Does assigning one object to another create a new object? Explain.
            // Answer: No. Assigning one object variable to another just copies the reference, meaning both variables will point to the same existing object in the heap rather than creating a new one.

            //c) What is the difference between copying an object and copying its reference?
            //Answer:Copying an object creates a new one in the heap with the same values, while copying a reference means just pointing to the address of the object in the heap.

            #endregion

            #region Question02

            //a) What is a Shallow Copy?
            //Answer:A shallow copy means creating a new object with the same values. Value types are newly created and assigned their values, but reference types (such as nested objects) are reused by copying their references.

            //b) What is a Deep Copy?
            //Answer:A Deep copy means creating a new object with the same values. Value types and refrence type are newly created and assigned their values in indpented objects

            //c) What happens to reference-type members when a Shallow Copy is created?
            //Answer:The reference-type members are reused.

            //d) What happens to reference-type members when a Deep Copy is created?
            //Answer:The reference-type members are newly created in a separate object.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //Answer:When you need to modify one object without affecting the other object. In a shallow copy, the reference types will be affected, but in a deep copy, the reference types are independent inside a separate object.

            #endregion

            #region Question03

            //a) What is a static field, and how is it different from an instance field?
            //Answer:A static field means it belongs to the class, it is created only once, shared among all objects, and can be accessed through the class. On the other hand, an instance field means it belongs to the object, and you need to create an object to access the field.

            // b) What is a static method? Can a static method directly access instance members ?
            //Answer:A static method means it belongs to the class, and you can access the method directly via the class name without creating an object. It cannot directly access instance members.

            //c) What is a static constructor, and when is it executed?
            //Answer:A static constructor is a special constructor that runs automatically before any static member is accessed or the first instance is created.

            //d) What is a static class? Can you create an object from a static class?
            //Answer:A static class acts as a container that groups static members together, and it cannot be instantiated.


            #endregion

            #region Question04

            //a) What is an Extension Method?
            //Answer:Extension methods allow you to add new methods to existing types without modifying the original type.

            //b) What keyword must be used in the first parameter of an extension method?
            //Answer:this keyword.

            //c) Where must an extension method be declared?
            //Answer:It must be declared inside a static class, and the method itself must be static.

            //d) Can an extension method access private members of the class it extends?
            //Answer:No, because the extension method is not a class member, so it cannot access private members.

            #endregion

            #region Question05

            //a) What is a Partial Class?
            //Answer:A partial class allows a single class definition to be split across multiple files to improve organization and maintainability.

            //b) Why would a developer split one class into multiple files?
            //Answer:to improve organization and maintainability.

            //c) What is a Partial Method?
            //Answer:A partial method allows a method's declaration and its implementation to be split across different files of a partial class.

            //d) What happens if a declared partial method has no implementation?
            //Answer:The compiler ignores all calls to the method.


            #endregion

            #endregion


        }
    }
}
