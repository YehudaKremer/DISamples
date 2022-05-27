public class Class1 : IClass1
{
    public Class1()
    {
        Console.WriteLine("new instance of Class1");
    }

    public int MyProperty { get; set; }
    public void PrintHelloWorld()
    {
        Console.WriteLine("Hello World");
    }
}