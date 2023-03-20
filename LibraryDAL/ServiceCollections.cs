using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryDAL
{
    public static class ServiceCollections
    {
        public static IServiceCollection  AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddTransient<ILibraryService, LibraryService>();
            serviceDescriptors.AddTransient<IDictionaryCommands, DictionaryCommands >();
            serviceDescriptors.AddTransient<IRunner, Runner>();
            return serviceDescriptors;
        }
    }
}
