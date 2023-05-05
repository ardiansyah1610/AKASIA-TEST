using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkalianSederhana.Services
{
    public class Nomor3
    {
        public static void Run()
        {
            var hasil = perkalianSederhana();
            Console.WriteLine($"Nomor 3 : {hasil}");
        }

        public static int perkalianSederhana(int j = 5, int k = 4)
        {
            int hasil = 0;
            while (j > 0)
            {
                hasil += k;
                j--;
            }

            return hasil;
        }
    }
}
