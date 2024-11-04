namespace Forms_good
{
    internal static class Program
    {
        public class Forma : Form1
        {
            public Forma(string tytul, int szerokosc, int wysokosc)
            {
                Text = tytul;
                Width = szerokosc;
                Height = wysokosc;
                MinimizeBox = true;
                MaximizeBox = true;
                StartPosition = FormStartPosition.CenterScreen;

            }
        }
        [STAThread]
        static void Main(string[] args)
        {
            string tytul;
            int szerokosc;
            int wysokosc;

            if (args.Length < 3)
            {
                tytul = "Ala i Ola";
                szerokosc = 600;
                wysokosc = 800;
            }
            else
            {
                tytul = args[0];
                try
                {
                    szerokosc = Int32.Parse(args[1]);
                    wysokosc = Int32.Parse(args[2]);
                }
                catch (Exception)
                {
                    szerokosc = 600;
                    wysokosc = 800;
                }
            }
            ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
            // Application.Run(new Form2())
            // Application.Run(new Form3());
            // Application.Run(new Form5());
            // Application.Run(new ComboBox());
            // Application.Run(new DateRangePickerForm());
             Application.Run(new Numeric());
        }
    }