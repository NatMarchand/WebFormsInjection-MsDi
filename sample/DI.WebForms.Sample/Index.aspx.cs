using System;
using System.Web.UI;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public partial class Index : Page
    {
        protected IDependency Dependency { get; }

        public Index(IDependency dependency)
        {
            Dependency = dependency;
        }
    }
}