using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October_28_Lab_CSharp_OOP
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var encryption = new Encryption("beauty");

            Console.WriteLine(encryption.Encrypt("thisistheplaintext"));

            Console.WriteLine(encryption.Decrypt("ttihhnietspeilxsat"));

        }
    }
}
