using System;
using Microsoft.Win32;

namespace EasyPATH
{
    /// <summary>
    /// Handles the registry editing for the EasyPATH application.
    /// </summary>
    public class RegistryHandler
    {
        /// <summary>
        /// The root sub key path of the new registry entry.
        /// </summary>
        private string rootPath = @"*\shell\EasyPATH";
        /// <summary>
        /// The command sub key path of the root registry entry.
        /// </summary>
        private string commandPath = @"*\shell\EasyPATH\command";
        /// <summary>
        ///  The root sub key object of the new registry entry.
        /// </summary>
        RegistryKey rootKey = null;
        /// <summary>
        /// The command sub key object of the root registry entry.
        /// </summary>
        RegistryKey commandKey = null;

        /// <summary>
        /// Adds a custom registry key to introduce a new context menu option upon right clicking.
        /// </summary>
        /// <param name="installPath">The path to EasyPATH.exe.</param>
        public void addRegistryKey(string installPath)
        {
            try
            {
                // Open the root key.
                rootKey = Registry.ClassesRoot.CreateSubKey(rootPath);

                // Change the context menu entry text.
                if (rootKey != null)
                    rootKey.SetValue("", "Add to PATH");
                else
                    return;

                // Open the command sub key.
                commandKey = Registry.ClassesRoot.CreateSubKey(commandPath);

                // Change the command value to the install path of easyPATH.
                if (commandKey != null)
                    commandKey.SetValue("", installPath + " \"%1\"");
                else
                    return;
            }
            finally
            {
                // Close both registry keys.

                if (rootKey != null)
                    rootKey.Close();
                if (commandKey != null)
                    commandKey.Close();
            }

            return;
        }

        /// <summary>
        /// Removes the custom registry key.
        /// </summary>
        public void removeRegistryKey()
        {
            try
            {
                // Open the root key.
                rootKey = Registry.ClassesRoot.OpenSubKey(rootPath);

                if (rootKey != null)
                {
                    // Close and recursively delete the root key and it's sub keys
                    rootKey.Close();
                    Registry.ClassesRoot.DeleteSubKeyTree(rootPath);
                }
                else
                    return;
            }
            finally
            {
                // Do nothing
            }
        }

        /// <summary>
        /// Adds the path of a folder/program to the list of system environment variables.
        /// </summary>
        /// <param name="path">The user-specified path to a folder/program.</param>
        public void addEnvironmentVar(string path)
        {
            // Get the current text in the PATH environment variable.
            string currentPath = Environment.GetEnvironmentVariable("PATH");

            // The path to be appended to the current path string.
            string appendPath = @path;

            // Append the user-specified path to the PATH environment variable.
            Environment.SetEnvironmentVariable("PATH", currentPath + ";" + appendPath, EnvironmentVariableTarget.Machine);
        }
    }
}
