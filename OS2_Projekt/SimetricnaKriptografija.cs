using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OS2_Projekt
{
    public class SimetricnaKriptografija
    {
        AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
       
        public SimetricnaKriptografija()
        {

        }

        public void GenerirajTajniKljuc()
        {
            string kljuc = "";
            
            AES.KeySize = 128;
            AES.Mode = CipherMode.CBC;
            AES.GenerateKey();
            
            kljuc = Convert.ToBase64String(AES.Key);
            
            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\tajni_Kljuc.txt", kljuc);
        }

        public void Kriptiraj(byte[] tajniKljuc, string sadrzajDatoteke)
        {
            byte[] kriptiraniSadrzajDatoteke;

            AES.Key = tajniKljuc;

            string inicijalizacijskiVektor = "";
            AES.GenerateIV();
            inicijalizacijskiVektor = Convert.ToBase64String(AES.IV);
            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\inicijalizacijski_Vektor.txt", inicijalizacijskiVektor);

            ICryptoTransform encryptor = AES.CreateEncryptor(AES.Key, AES.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(sadrzajDatoteke);
                    }
                    kriptiraniSadrzajDatoteke = msEncrypt.ToArray();
                }
            }

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\kriptirani_tekstS.txt", Convert.ToBase64String(kriptiraniSadrzajDatoteke));
        }

        public void Dekripiraj(byte[] tajniKljuc, byte[] inicijalizacijskiVektor, string sadrzajDatoteke)
        {
            byte[] kriptiraniSadrzajDatoteke = Convert.FromBase64String(sadrzajDatoteke);

            string dekriptiraniSadrzajDatoteke = null;

            AES.Key = tajniKljuc;
            AES.IV = inicijalizacijskiVektor;

            ICryptoTransform decryptor = AES.CreateDecryptor(AES.Key, AES.IV);

            using (MemoryStream msDecrypt = new MemoryStream(kriptiraniSadrzajDatoteke))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        dekriptiraniSadrzajDatoteke = srDecrypt.ReadToEnd();
                    }
                }
            }

            File.WriteAllText(@"C:\Users\Andja\Desktop\OS2_Projekt\Datoteke\dekriptirani_tekstS.txt", dekriptiraniSadrzajDatoteke);
        }
    }
}
