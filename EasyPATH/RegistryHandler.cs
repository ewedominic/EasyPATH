using Microsoft.Win32;
using System;

namespace EasyPATH
{
    /// <summary>
    /// Handles the registry editing for the EasyPATH application.
    /// </summary>
    public class RegistryHandler
    {
        /// <summary>
        /// The root sub key of the new registry entry.
        /// </summary>
        private string root = @"*\shell\EasyPATH";
        /// <summary>
        /// The command sub key of the root registry entry.
        /// </summary>
        private string command = @"*\shell\EasyPATH\command";

        /// <summary>
        /// Adds a custom registry key to introduce a new context menu option upon right clicking.
        /// </summary>
        /// <param name="installPath">The path to EasyPATH.exe.</param>
        /// <returns>Returns true if the key was added successfully, false otherwise.</returns>
        public bool addRegistryKey(string installPath)
        {

            return false;
        }

        /// <summary>
        /// Removes the custom registry key.
        /// </summary>
        /// <returns>Returns true if the key was removed successfully, false otherwise.</returns>
        public bool removeRegistryKey()
        {

            return false;
        }

        /// <summary>
        /// Checks whether or not the custom registry key already exists.
        /// </summary>
        /// <returns>Returns true if the key exists, false otherwise.</returns>
        private bool keyExists()
        {

            return false;
        }
    }
}
