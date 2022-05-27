public class Class2 : IClass2
{
    private readonly IClass1 class1;

    public int MyProperty { get; set; }

    public Class2(IClass1 class1)
    {
        this.class1 = class1;
    }
}