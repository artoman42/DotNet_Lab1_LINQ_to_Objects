using System;
using LibraryDAL;
using Microsoft.Extensions.DependencyInjection;

namespace Lab1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddServices();
            IServiceProvider serviceProvider = serviceDescriptors.BuildServiceProvider();
            serviceProvider.GetService<IRunner>().Run();
        }
    }
}
