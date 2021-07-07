using System;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'c';
            int y = x; // => CHUYEN DOI ngam dinh

            int tuoi = 20;
            long abc = tuoi; // chuyen doi ngam dinh

            long luong = 4000000000;
            int luong1 = (int)luong; // => ko cho phep ngam dinh
            Console.WriteLine(luong1);


        }
    }
}
