using System.Runtime.InteropServices;

namespace Mod_Installer
{
    public static class Extensions
    {
        public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
            where TControlType : Control
        {
            if (control.InvokeRequired)
                control.Invoke(new Action(() => del(control)));
            else
                del(control);
        }
    }

    internal static class Program
    {
        internal static string gameFolderPath = string.Empty;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            Version version = new Version(0,1,0,0);

            Console.WriteLine("[BOOT] Installer is starting up...");
            Console.WriteLine("[BOOT] Installer and the mod are created by Treeshold (artv15).");
            Console.WriteLine($"[BOOT] Installer version: {version}.");

            Console.WriteLine("[BOOT] Starting up the picker...");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new InstallerPicker());
        }
    }
}