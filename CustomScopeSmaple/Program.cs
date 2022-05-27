using Microsoft.Extensions.DependencyInjection;

namespace CustomScopeSmaple
{
    public class Program
    {
        public static IServiceProvider? ServicesProvider { get; private set; }

        public static void Main()
        {
            var Services = new ServiceCollection();

            Services.AddScoped<IClass1, Class1>();

            ServicesProvider = Services.BuildServiceProvider();

            //using (var scope = ServicesProvider.CreateScope())
            //{
            //    var class1scoped = scope.ServiceProvider.GetRequiredService<IClass1>();
            //    class1scoped.PrintHelloWorld();
            //}

            var class1 = ServicesProvider.GetRequiredService<IClass1>();
            class1.PrintHelloWorld();

            var class1Again = ServicesProvider.GetRequiredService<IClass1>();
            class1Again.PrintHelloWorld();

            Console.ReadLine();
        }
    }
}
