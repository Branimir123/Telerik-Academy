using System;
using System.Text;

namespace Problem2.Barcodes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] codes =
            {
                "||:::",
                ":::||",
                "::|:|",
                "::|||",
                ":|::|",
                ":|:|:",
                ":||::",
                "|:::|",
                "|::|:",
                "|:|::",
            };

            Console.WriteLine("Insert 3-digit number");
            string num = Console.ReadLine();

            Array.Reverse(num.ToCharArray());

            var strBld = new StringBuilder();

            for (int i = 0; i < num.Length; i++)
            {
                strBld.Append(codes[num[i]]);
                Console.WriteLine(num[i]);
            }

            Console.WriteLine(strBld.ToString());
        }
    }
}
