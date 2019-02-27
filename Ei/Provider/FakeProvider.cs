using Com.Setarit.Ei.Provider.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider
{
    class FakeProvider : IEi
    {
        private readonly Fake configuration;

        public FakeProvider(Fake configuration)
        {
            this.configuration = configuration;
        }

        public void CreateIssue(string title, string description)
        {
            //do nothing  
        }

        public void CreateIssue(string title, string description, System.Exception exception)
        {
            //do nothing
        }

        public void CreateIssue(string title, System.Exception exception)
        {
            //do nothing
        }
    }
}
