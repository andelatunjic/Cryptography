using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OS2_Projekt
{
    public class DigitalniPotpis
    {
        SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);

        byte[] hash;
        public DigitalniPotpis()
        {

        }

        public void IzradiSazetak(string nazivDatoteke)
        {
            byte[] bytesSadrzajDatoteke = File.ReadAllBytes(nazivDatoteke);
            hash = SHA256.ComputeHash(bytesSadrzajDatoteke);
            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\sazetak.txt", Convert.ToBase64String(hash));
        }

        public void Potpisi(string privatniKljuc, string nazivDatoteke)
        {
            RSA.FromXmlString(privatniKljuc);

            string hash = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\sazetak.txt");
            byte[] byteHash = Convert.FromBase64String(hash);

            byte[] digitalniPotpis = RSA.SignHash(byteHash, "SHA256");

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\digitalni_Potpis.txt", Convert.ToBase64String(digitalniPotpis));
        }

        public bool Provjeri(string javniKljuc, string sadrzajDatotekeDigPotpisa)
        {
            RSA.FromXmlString(javniKljuc);

            string hash = File.ReadAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\sazetak.txt");
            byte[] byteHash = Convert.FromBase64String(hash);

            byte[] byteDigitalniPotpis = Convert.FromBase64String(sadrzajDatotekeDigPotpisa);
            
            bool provjera = RSA.VerifyHash(byteHash, "SHA256", byteDigitalniPotpis);

            if (provjera == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
