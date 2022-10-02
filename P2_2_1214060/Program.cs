using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Kalkulator Gaji Karyawan ===");
            Console.Write("Ketikan gaji anda: ");
            var gaji = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var persen_tunjangan = (float)(20.0 / 100.0);
            var persen_bonus = (float)(15.0 / 100.0);
            var persen_pph = (float)(3.5 / 100);

            var persen_tunjangan2 = (persen_tunjangan) * 100 + "%";
            var persen_bonus2 = (persen_bonus) * 100 + "%";
            var persen_pph2 = (persen_pph) * 100 + "%";

            var tunjangan = gaji * persen_tunjangan;
            var bonus = gaji * persen_bonus;
            var pph = gaji * persen_pph;
            var total_gaji = gaji + tunjangan + bonus;
            var gaji_bersih = total_gaji - pph;

            string tambah = (" + ");
            string kali = (" * ");
            string kurang = (" - ");

            Console.Write("Perhitungan tunjangan: ");
            Console.WriteLine(gaji + kali + persen_tunjangan2);
            Console.WriteLine("Tunjangan Anda sejumlah: Rp " + tunjangan + ",-");
            Console.WriteLine(" ");

            Console.Write("Perhitungan Bonus: ");
            Console.WriteLine(gaji + kali + persen_bonus2);
            Console.WriteLine("Bonus Anda sejumlah: Rp " + bonus + ",-");
            Console.WriteLine(" ");

            Console.Write("Kalkulasi PPH: ");
            Console.WriteLine(gaji + kali + persen_pph2);
            Console.WriteLine("PPH Anda sejumlah: Rp " + pph + ",-");
            Console.WriteLine(" ");

            Console.Write("Perhitungan total gaji: ");
            Console.WriteLine(gaji + tambah + tunjangan + tambah + bonus);
            Console.WriteLine("Keseluruhan gaji kotor Anda sejumlah: Rp " + total_gaji + ",-");
            Console.WriteLine(" ");

            Console.Write("Perhitungan gaji bersih: ");
            Console.WriteLine(total_gaji + kurang + pph);
            Console.WriteLine("Keseluruhan gaji bersih Anda sejumlah: Rp " + gaji_bersih + ",-");
            Console.WriteLine(" ");
        }
    }
}
