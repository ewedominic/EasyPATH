using Microsoft.Win32;
using System;

namespace EasyPATH
{
    /// <summary>
    /// Handles the registry editing for the EasyPATH application.
    /// </summary>
    public class RegistryHandler
    {
        // The root sub key of the new registry entry.
        private string root = @"*\shell\EasyPATH";
        // The command sub key of the root registry entry.
        private string command = @"*\shell\EasyPATH\command";

        /// <summary>
        /// Adds a custom registry key to introduce a new context menu option upon right clicking.
        /// </summary>
        /// <param name="installPath">The path to EasyPATH.exe.</param>
        /// <returns></returns>
        public bool addRegistryKey(string installPath)
        {

            return false;
        }

        /// <summary>
        /// Removes the custom registry key.
        /// </summary>
        /// <returns></returns>
        public bool removeRegistryKey()
        {

            return false;
        }

        /// <summary>
        /// Checks whether or not the custom registry key already exists.
        /// </summary>
        /// <returns></returns>
        private bool keyExists()
        {

            return false;
        }
    }
}
