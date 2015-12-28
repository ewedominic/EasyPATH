using System;
using System.IO;

namespace EasyPATH
{
    /// <summary>
    /// Handles the control of the EasyPATH application.
    /// </summary>
    public class EasyPATH
    {
        /// <summary>
        /// Determines which registry operation to run based on the input arguments.
        /// </summary>
        /// <param name="args">Input arguments. This should either be "install" or "uninstall" based on whether or not the user has previously installed EasyPATH.</param>
        static void Main(string[] args)
        {
            // Make sure there is only 1 argument.
            if (args.Length != 1)
                return;

            // Get the location of EasyPATH.exe.
            string installPath = Path.GetFullPath(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Make sure EasyPATH.exe actually exists.
            if (!File.Exists(installPath))
                return;

            // Create an instance of RegistryHandler.
            RegistryHandler regHandler = new RegistryHandler();

            // If the input argument is "uninstall", remove the custom registry entry from the computer, otherwise if the input argument is "install" add a custom registry to the computer.
            if (args[0] == "uninstall")
            {
                regHandler.removeRegistryKey();
            }
            else if (args[0] == "install")
            {
                regHandler.addRegistryKey(installPath);
            }
        }
    }
}