using Com.Setarit.Ei.Provider.Configuration;
using Com.Setarit.Ei.Exception;

namespace Com.Setarit.Ei.Factory
{
    interface IProviderFactory
    {
        /// <summary>
        /// Creates the provider
        /// </summary>
        /// <param name="configuration">The configuration to use</param>
        /// <returns>The Provider (IEi) to make requests with</returns>
        /// <exception cref="InvalidProviderException">When the provider is not supported</exception>
        IEi CreateFrom(IConfiguration configuration);
    }
}
