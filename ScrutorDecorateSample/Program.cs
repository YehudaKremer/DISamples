using Microsoft.Extensions.DependencyInjection;

namespace ScrutorDecorateSample
{
    public class Program
    {
        public static IServiceProvider? ServicesProvider { get; private set; }

        public static void Main()
        {
            var Services = new ServiceCollection();

            Services.AddScoped<IClass1, Class1>();
            Services.Decorate<IClass1, Class1Decorator>();

            ServicesProvider = Services.BuildServiceProvider();

            var class1 = ServicesProvider.GetRequiredService<IClass1>();
            class1.PrintHelloWorld();


            Console.ReadLine();
        }
    }
}


//public static readonly IServiceProvider ServicesProvider = new ServiceCollection()
//    .AddScoped<IClass1, Class1>()
//    .Decorate<IClass1, Class1Decorator>()
//    .BuildServiceProvider();
