using System;
using System.Web;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        { 
            var collection = new ServiceCollection();
            collection.AddScoped<IDependency, Dependency>();
            var provider = new ServiceProvider(collection.BuildServiceProvider());
            HttpRuntime.WebObjectActivator = provider;
        }
    }
}