using Microsoft.Extensions.DependencyInjection;

namespace ScrutorSample
{
    public class Program
    {
        public static IServiceProvider? ServicesProvider { get; private set; }

        public static void Main()
        {
            var Services = new ServiceCollection();

            Services.AddScoped<IClass1, Class1>()
                .AddScoped<IClass2, Class2>()
                .AddScoped<IClass3, Class3>();

            //Services.Scan(scan => scan
            //    .FromAssemblyOf<ITransientService>()
            //    .AddClasses(classes => classes.AssignableTo<ITransientService>())
            //    .AsImplementedInterfaces()
            //    .WithTransientLifetime()
            //);

            ServicesProvider = Services.BuildServiceProvider();


            var class2 = ServicesProvider.GetRequiredService<IClass2>();

            Console.ReadLine();
        }
    }
}
