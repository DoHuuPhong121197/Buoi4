using System;

namespace SoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so phan tu: " );
            int n = int.Parse(Console.ReadLine());
            int [] mang = new int[n];
            int bienDem = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("phan tu: " +i);
                mang[i] = int.Parse(Console.ReadLine());
                int Giatri = mang[i];
                for (int j = 1; j < Giatri; j++)
                {
                    if(Giatri % j == 0)
                    {
                        bienDem++;
                    }
                }
                if(bienDem == 2)
                {
                    Console.WriteLine("So da cho la so Nguyen To: " + Giatri);
                }
                else
                {
                    Console.WriteLine("So da cho khong la so Nguyen To: ");
                }
            } 
        }
    }
}
