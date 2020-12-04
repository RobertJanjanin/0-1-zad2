using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunde;
            int minute;
            int sekundi;


            Console.WriteLine("Upisi broj sekundi: ");

            sekunde = Convert.ToInt32(Console.ReadLine());

            minute = sekunde / 60;

            sekundi = sekunde % 60;

            Console.WriteLine(+minute+" minute i  "+ sekundi+"sekundi");

            Console.ReadKey();
        }
    }
}
