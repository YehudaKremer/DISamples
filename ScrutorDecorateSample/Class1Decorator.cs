namespace ScrutorDecorateSample
{
    public class Class1Decorator : IClass1
    {
        private readonly IClass1 class1;

        public Class1Decorator(IClass1 class1)
        {
            Console.WriteLine("new instance of Class1Decorator");
            this.class1 = class1;
        }

        public void PrintHelloWorld()
        {
            Console.WriteLine("Some log from the decorator class");
            class1.PrintHelloWorld();
        }
    }
}
