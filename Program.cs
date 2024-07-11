using System;
using System.Numerics;

namespace SCC_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            BigInteger ChieuDai = BigInteger.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            BigInteger ChieuRong = BigInteger.Parse(Console.ReadLine());
            BigInteger DienTich = ChieuDai * ChieuRong;
            Console.WriteLine("Dien tich hinh chu nhat la: " + DienTich);
        }
    }
}