using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_good.Egzaminy
{
    public partial class Inf04_2023_01_SG : Form
    {
        public Inf04_2023_01_SG()
        {
            InitializeComponent();

        }
        string wynikoweHaslo = "";
        private void generate_password(object sender, EventArgs e)
        {
            
            // Zestawy znaków
            string[] tablica_duze = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] tablica_male = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] tablica_cyfry = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] tablica_specialne = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=" };

            int dlugoscHasla;
            if (!int.TryParse(textBox3.Text, out dlugoscHasla) || dlugoscHasla <= 0)
            {
                MessageBox.Show("Podaj poprawną długość hasła.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            List<string> haslo = new List<string>();

            if (checkBox3.Checked && dlugoscHasla > haslo.Count)
            {
                haslo.Add(tablica_specialne[random.Next(tablica_specialne.Length)]);
            }

            if (checkBox2.Checked && dlugoscHasla > haslo.Count)
            {
                haslo.Add(tablica_cyfry[random.Next(tablica_cyfry.Length)]);
            }

            if (checkBox1.Checked && dlugoscHasla > haslo.Count)
            {
                haslo.Add(tablica_duze[random.Next(tablica_duze.Length)]);
            }

            while (haslo.Count < dlugoscHasla)
            {
                haslo.Add(tablica_male[random.Next(tablica_male.Length)]);
            }

            haslo = haslo.OrderBy(x => random.Next()).ToList();

            wynikoweHaslo = string.Join("", haslo);

            MessageBox.Show($"Wygenerowane hasło: {wynikoweHaslo}", "Hasło", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate the password
            generate_password(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string stanowisko = groupBox1.Text;

            generate_password(sender, e);

            string message = $"Dane pracownika: imię: {imie}, nazwisko: {nazwisko}, stanowisko: {stanowisko}\nHasło: {wynikoweHaslo}";
            MessageBox.Show(message, "Informacje i Hasło", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
