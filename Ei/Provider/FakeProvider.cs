using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider
{
    class FakeProvider : IEi
    {
        public void CreateIssue(string title, string description)
        {
           
        }

        public void CreateIssue(string title, string description, Exception exception)
        {
            
        }

        public void CreateIssue(string title, Exception exception)
        {
            
        }
    }
}
