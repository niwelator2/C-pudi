namespace Forms_good
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
           // Application.Run(new Form1());
            Application.Run(new Form2());
        }
    }
}