using Com.Setarit.Ei.Provider.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider
{
    class GithubProvider :IEi
    {
        private readonly string endpoint;
        private readonly Github configuration;

        public GithubProvider(Github configuration)
        {
            this.configuration = configuration;
            this.endpoint = "https://api.github.com";
        }

        public void CreateIssue(string title, string description)
        {
            throw new NotImplementedException();
        }

        public void CreateIssue(string title, string description, System.Exception exception)
        {
            throw new NotImplementedException();
        }

        public void CreateIssue(string title, System.Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
