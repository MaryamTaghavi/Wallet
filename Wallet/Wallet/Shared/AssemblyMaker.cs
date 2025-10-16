using System.Reflection;

namespace Wallet.Shared; 

public static class AssemblyMaker
{
    private static readonly Lazy<Assembly> _currentAssembly =
        new Lazy<Assembly>(() => typeof(AssemblyMaker).Assembly);

    public static Assembly ApplicationAssembly = _currentAssembly.Value;
}
