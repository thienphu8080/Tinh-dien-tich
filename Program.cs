using System.Numerics;
using System.Text;

namespace Tính_số_lớn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính diện tịch hình vuông");
            Console.Write("Độ dài cạnh: ");
            BigInteger canh = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích tam giác {0}", canh * canh);
        }
    }
}
