using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace OS2_Projekt
{
    public partial class Pocetna : Form
    {
        SimetricnaKriptografija simetricnaKriptografija = new SimetricnaKriptografija();
        AsimetricnaKriptografija asimetricnaKriptografija = new AsimetricnaKriptografija();
        DigitalniPotpis digitalniPotpis = new DigitalniPotpis();

        string nazivDatoteke = "";
        string sadrzajDatoteke = "";

        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nazivDatoteke = openFileDialog.FileName;
            }
            sadrzajDatoteke = File.ReadAllText(nazivDatoteke);
            txtOrginalniTekst.Text = sadrzajDatoteke;
            txtNazivDatoteke.Text = nazivDatoteke;
        }

        private void btnGenerirajSimKlj_Click(object sender, EventArgs e)
        {
           simetricnaKriptografija.GenerirajTajniKljuc();
            MessageBox.Show("Uspješno generiran tajni ključ.");
        }

        private void btnKriptirajSim_Click(object sender, EventArgs e)
        {
            simetricnaKriptografija.Kriptiraj(procitajTajniKluc(), sadrzajDatoteke);
            MessageBox.Show("Uspješno kriptirano.");
        }

        private void btnDekriptirajSim_Click(object sender, EventArgs e)
        {
            simetricnaKriptografija.Dekripiraj(procitajTajniKluc(), procitajInicijalizacijskiVektor(), sadrzajDatoteke);
            MessageBox.Show("Uspješno dekriptirano.");
        }

        private byte[] procitajTajniKluc()
        {
            string tajniKljuc = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\tajni_Kljuc.txt");
            return Convert.FromBase64String(tajniKljuc);
        }

        private byte[] procitajInicijalizacijskiVektor()
        {
            string inicijalizacijskiVektor = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\inicijalizacijski_Vektor.txt");
            return Convert.FromBase64String(inicijalizacijskiVektor);
        }

        private void btnGenerirajParKlj_Click(object sender, EventArgs e)
        {
            asimetricnaKriptografija.GenerirajKljuceve();
            MessageBox.Show("Uspješno generiran par ključeva.");
        }

        private void btnKriptirajAsim_Click(object sender, EventArgs e)
        {
            asimetricnaKriptografija.Kriptiraj(procitajJavniKljuc(), sadrzajDatoteke);
            MessageBox.Show("Uspješno kriptirano.");
        }

        private void btnDekriptirajAsim_Click(object sender, EventArgs e)
        {
            asimetricnaKriptografija.Dekripiraj(procitajPrivatniKljuc(), sadrzajDatoteke);
            MessageBox.Show("Uspješno dekriptirano.");
        }

        private string procitajJavniKljuc()
        {
            string javniKljuc = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\javni_Kljuc.txt");
            return javniKljuc;
        }

        private string procitajPrivatniKljuc()
        {
            string privatniKljuc = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\privatni_Kljuc.txt");
            return privatniKljuc;
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            digitalniPotpis.IzradiSazetak(nazivDatoteke);
            MessageBox.Show("Izradili ste sazetak.");
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            digitalniPotpis.Potpisi(procitajPrivatniKljuc(), nazivDatoteke);
            MessageBox.Show("Potpisano.");
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            bool provjera = digitalniPotpis.Provjeri(procitajJavniKljuc(), sadrzajDatoteke);

            if (provjera == true)
            {
                MessageBox.Show("Potpis je u redu.");
            }
            else
            {
                MessageBox.Show("Potpis nije u redu.");
            }
        }

    }
}
