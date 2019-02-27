using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei
{
    public interface IEi
    {
        /// <summary>
        /// Creates an issue in the repository
        /// </summary>
        /// <param name="title">The title of the issue</param>
        /// <param name="description">The description of the issue</param>
        void CreateIssue(string title, string description);

        /// <summary>
        /// Creates an issue in the repository
        /// </summary>
        /// <param name="title">The title of the issue</param>
        /// <param name="description">The description of the issue</param>
        /// <param name="exception">The exception that needs to be logged in the issue</param>
        void CreateIssue(string title, string description, System.Exception exception);

        /// <summary>
        /// Creates an issue in the repository
        /// </summary>
        /// <param name="title">The title of the issue</param>
        /// <param name="exception">The exception that needs to be logged in the issue</param>
        void CreateIssue(string title, System.Exception exception);
    }
}
