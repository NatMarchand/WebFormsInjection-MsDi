using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    [DebuggerDisplay("Dependency #{" + nameof(Id) + "}")]
    public class Dependency : IDependency
    {
        private static int _id;

        public int Id { get; }

        public Dependency()
        {
            Id = Interlocked.Increment(ref _id);
        }

        public string GetFormattedTime() => DateTimeOffset.UtcNow.ToString("f", CultureInfo.InvariantCulture);
    }

    public interface IDependency
    {
        int Id { get; }
        string GetFormattedTime();
    }
}