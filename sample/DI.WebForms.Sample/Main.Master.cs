using System;
using System.Web.UI;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public partial class Main : MasterPage
    {
        protected IDependency Dependency { get; }

        public Main(IDependency dependency)
        {
            Dependency = dependency;
        }
    }
}