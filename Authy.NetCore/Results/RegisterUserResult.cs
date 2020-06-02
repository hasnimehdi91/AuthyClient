using System.Collections.Generic;

namespace Authy.netcore.Results
{
    /// <summary>
    /// The result of a request to register a user
    /// </summary>
    public class RegisterUserResult : AuthyResult
    {
        /// <summary>
        /// The user id of a succesful registration event
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The user information on Authy API
        /// </summary>
        public Dictionary<string, string> User { get; set;}
    }
}
