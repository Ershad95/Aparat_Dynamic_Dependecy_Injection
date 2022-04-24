using WebApplication2.Services;
using WebApplication2.Entites;

namespace WebApplication2.Extentions
{
    public static class IServiceCollectionExtention
    {
        public static void AddAllServices(this IServiceCollection services)
        {
            var serviceContainer = "Services";
            var asm = AppDomain.CurrentDomain
                .GetAssemblies()
                .Single(x =>
                x.FullName
                .Contains(AppDomain.CurrentDomain.FriendlyName));

            var allRelatedClassServices = asm.DefinedTypes
                .Where(x => x.IsClass && x.FullName.Contains(serviceContainer));

            var allRelatedInterfaceServices = asm.DefinedTypes
                .Where(x => x.IsInterface && x.FullName.Contains(serviceContainer));

            foreach (var classService in allRelatedClassServices)
            {
                var iservice = allRelatedInterfaceServices.Single(x => x.Name == $"I{classService.Name}");
                services.AddScoped(iservice, classService);
            }
        }
    }
}
