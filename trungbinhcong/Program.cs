using System;

namespace trungbinhcong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("phan tu {0}" ,i);
                mang[i] = int.Parse(Console.ReadLine());
            }

            // b1_ tinh tong tat ca cac phan tu trong mang
            // b2_ tbc = tong/so phan tu

            int tong = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                int giaTriPhanTu = mang[i];
                tong = tong + giaTriPhanTu;
            }
            double trungbinh = (double)tong / n;
            // Console.WriteLine("trungbinhcong:{0} ", trungbinh);
            Console.WriteLine("trungbinhcong: " + trungbinh);

        }
    }
}
