public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized yet will result in 0
        int value = MyProperty; 
        Console.WriteLine(value); // Output: 0

        //However, if you try to modify the property before initialization you will get an error. 
        //MyProperty++; //This will throw an exception.
        MyProperty = 10; // this is fine
        Console.WriteLine(MyProperty); // Output: 10
    }
}