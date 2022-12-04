namespace BuilderForms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Game("C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\maps\\plansza01.txt"));
    }
}