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




            #endregion


        }
    }
}
