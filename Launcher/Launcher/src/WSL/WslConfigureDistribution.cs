using System.Runtime.InteropServices;
using Windows.Win32.Foundation;

namespace WSL;

public static partial class WslApiLoader {
    public static void WslConfigureDistribution(
        string distributionName,
        ulong defaultUID,
        WSL_DISTRIBUTION_FLAGS wslDistributionFlags
    ) {
        [DllImport("wslapi.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        // ReSharper disable once LocalFunctionHidesMethod
        static extern HRESULT WslConfigureDistribution(
            string distributionName,
            ulong defaultUID,
            WSL_DISTRIBUTION_FLAGS wslDistributionFlags
        );
        CheckResult(WslConfigureDistribution(distributionName, defaultUID, wslDistributionFlags));
    }
}
