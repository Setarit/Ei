using System;
using System.Collections.Generic;
using System.Text;
using Com.Setarit.Ei.Provider.Configuration;
using System.Runtime.CompilerServices;
using Com.Setarit.Ei.Exception;

[assembly:InternalsVisibleTo("EiTests")]
namespace Com.Setarit.Ei.Factory
{
    class ProviderFactory : IProviderFactory
    {        
        public IEi CreateFrom(IConfiguration configuration)
        {
            if (configuration is Fake)
            {

            }
            else if (configuration is Bitbucket)
            {

            }
            else if (configuration is Github)
            {

            }
            else
            {
                Type type = configuration.GetType();
                throw new InvalidProviderException("The provider for configuration " + type.FullName + " is unknown");
            }
            return null;
        }
    }
}
