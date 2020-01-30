using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Authy.netcore
{
    public class AuthyHelpers
    {

        ///<summary>
        /// Remove all non-digits from the string
        /// </summary>
        ///<param name="value">The string to sanitize</param>
        public static string SanitizeNumber(string value) {
            return Regex.Replace(value, @"\D", string.Empty);
        }

        ///<summary>
        /// Validate the token entered by the user
        /// </summary>
        /// <param name="token">The token to validate</param>
        public static bool TokenIsValid(string token) {
            token = SanitizeNumber(token);

            return token.Length >= 6 && token.Length <= 10;
        }

        /// <summary>
        /// Gets the version of the Assembly.
        /// </summary>
        /// <returns>The version.</returns>
        public static string GetVersion() {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fvi.ProductVersion;

            return version;
        }

        /// <summary>
        /// Get the system information
        /// </summary>
        /// <returns>The .NET version</returns>
        public static string GetSystemInfo() {
            var runtimeVersion = Environment.Version;
            return $"Runtime v{runtimeVersion}";
        }

    }
}

