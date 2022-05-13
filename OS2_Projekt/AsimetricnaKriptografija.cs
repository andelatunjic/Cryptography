using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OS2_Projekt
{
    public class AsimetricnaKriptografija
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);

        public AsimetricnaKriptografija()
        {

        }

        public void GenerirajKljuceve()
        {
            string javniKljuc = RSA.ToXmlString(false);
            string privatniKljuc = RSA.ToXmlString(true);

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\javni_Kljuc.txt", javniKljuc);
            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\privatni_Kljuc.txt", privatniKljuc);
        }

        public void Kriptiraj(string javniKljuc, string sadrzajDatoteke)
        {
            RSA.FromXmlString(javniKljuc);

            byte[] bytesTekst = Encoding.Unicode.GetBytes(sadrzajDatoteke);
            byte[] bytesSifriraniText = RSA.Encrypt(bytesTekst, false);
            string sifriraniTekst = Convert.ToBase64String(bytesSifriraniText);

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\kriptirani_tekstA.txt", sifriraniTekst);
        }

        public void Dekripiraj(string privatniKljuc, string sadrzajDatoteke)
        {
            RSA.FromXmlString(privatniKljuc);

            byte[] bytesKriptiraniTekst = Convert.FromBase64String(sadrzajDatoteke);
            byte[] bytesCistiTekst = RSA.Decrypt(bytesKriptiraniTekst, false);
            string cistiTekst = Encoding.Unicode.GetString(bytesCistiTekst);

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\dekriptirani_tekstA.txt", cistiTekst);
        }
    }
}
