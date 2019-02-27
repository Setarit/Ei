using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider.Configuration
{
    public class Github:IConfiguration
    {
        /// <summary>
        /// The owner of the repository
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// The name of the repository
        /// </summary>
        public string Repository { get; set; }
        /// <summary>
        /// The username to use for authentication
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The personal access token for authentication
        /// </summary>
        public string PersonalAccessToken { get; set; }
    }
}
