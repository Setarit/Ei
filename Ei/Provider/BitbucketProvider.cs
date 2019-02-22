using Com.Setarit.Ei.Provider.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider
{
    class BitbucketProvider:IEi
    {
        private readonly string endpoint;
        private readonly Bitbucket configuration;

        public BitbucketProvider(Bitbucket configuration)
        {
            this.configuration = configuration;
            this.endpoint = "https://api.bitbucket.org/2.0";
        }

        public void CreateIssue(string title, string description)
        {
            throw new NotImplementedException();
        }

        public void CreateIssue(string title, string description, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void CreateIssue(string title, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
