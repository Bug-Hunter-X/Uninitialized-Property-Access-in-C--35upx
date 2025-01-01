public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public MyClass() { // Or initialize in the constructor
        MyProperty = 0; 
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now MyProperty is initialized
        MyProperty = 10;
    }
}