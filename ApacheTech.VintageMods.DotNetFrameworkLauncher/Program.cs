namespace ApacheTech.VintageMods.DotNetFrameworkLauncher
{
    internal static class Program
    {
        private static void Main()
        {
#if DEBUG 
#else
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("Launcher run in Release configuration. Please change to Debug configuration, and try again.");
            System.Console.ReadKey();
#endif
        }
    }
}