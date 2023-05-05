using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotensiPendapatanMaksimal.Services
{
    public class Nomor4
    {
        public static void Run()
        {
            // variabel harga anting per pasang
            int hargaRuby = 1000000;
            int hargaTopaz = 1250000;
            int hargaPermata = 3000000;

            // variabel jumlah anting per jenis
            int jumlahRuby = 5;
            int jumlahTopaz = 3;
            int jumlahPermata = 1;

            // hitung pendapatan maksimum KawanLamaJewel
            int pendapatanMax = (jumlahRuby / 2) * hargaRuby + (jumlahTopaz / 2) * hargaTopaz + (jumlahPermata / 2) * hargaPermata;

            // output hasil pendapatan maksimum
            Console.WriteLine("Nomor 4 : Potensi pendapatan maksimum dari toko KawanLamaJewel adalah: Rp. " + pendapatanMax);
        }
    }
}
