public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property explicitly to avoid default value issues.
        MyProperty = 0;  // Initialize to zero

        int value = MyProperty;
        Console.WriteLine(value); // Output: 0

        MyProperty++;
        Console.WriteLine(MyProperty); // Output: 1
    }
}    