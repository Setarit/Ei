using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Provider.Configuration
{
    public class Bitbucket:IConfiguration
    {
        /// <summary>
        /// The repository name as represented in the weburl.
        /// See: https://community.atlassian.com/t5/Answers-Developer-Questions/How-do-you-find-the-repo-slug/qaq-p/491177
        /// </summary>
        public string RepoSlug { get; set; }
        /// <summary>
        /// The repository owner as represented in the weburl
        /// </summary>
        public string RepoOwnerSlug { get; set; }
        /// <summary>
        /// The application password generated in the webinterface
        /// See: https://confluence.atlassian.com/bitbucket/app-passwords-828781300.html
        /// </summary>
        public string AppPassword { get; set; }
        /// <summary>
        /// The username to authenticate with
        /// </summary>
        public string Username { get; set; }
    }
}
