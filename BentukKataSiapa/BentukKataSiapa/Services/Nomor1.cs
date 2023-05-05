using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentukKataSiapa.Services
{
    public class Nomor1
    {
        public static void Run()
        {
            string inputString = "USOMAANAPAIUMANSYDNIP";
            int jumlahSiapa = HitungJumlahSiapa(inputString);
            Console.WriteLine("Nomor 1 : Jumlah kata SIAPA yang dapat dibentuk: " + jumlahSiapa);
        }

        public static int HitungJumlahSiapa(string inputString)
        {
            int jumlahSiapa = 0;
            char[] sisaKarakter = new char[0];
            foreach (char karakter in inputString)
            {
                if (karakter == 'S')
                {
                    Array.Resize(ref sisaKarakter, sisaKarakter.Length + 1);
                    sisaKarakter[sisaKarakter.Length - 1] = karakter;
                }
                else if (karakter == 'I' && Array.Exists(sisaKarakter, k => k == 'S'))
                {
                    sisaKarakter = Array.FindAll(sisaKarakter, k => k != 'S');
                    Array.Resize(ref sisaKarakter, sisaKarakter.Length + 1);
                    sisaKarakter[sisaKarakter.Length - 1] = karakter;
                }
                else if (karakter == 'A' && Array.Exists(sisaKarakter, k => k == 'I'))
                {
                    sisaKarakter = Array.FindAll(sisaKarakter, k => k != 'I');
                    Array.Resize(ref sisaKarakter, sisaKarakter.Length + 1);
                    sisaKarakter[sisaKarakter.Length - 1] = karakter;
                }
                else if (karakter == 'P' && Array.Exists(sisaKarakter, k => k == 'A'))
                {
                    sisaKarakter = Array.FindAll(sisaKarakter, k => k != 'A');
                    jumlahSiapa++;
                }
            }
            return jumlahSiapa;
        }
    }
}
