using System;

namespace TongGiaTriTuyetDoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            //int tong1 = 0;
            //int tong2 = 0;
            //for (int i = 0; i < mang.Length; i++)
            //{
            //    Console.WriteLine("phan tu" + i);
            //    mang[i] = int.Parse(Console.ReadLine());
            //    if (mang[i] < 0)
            //    {
            //        mang[i] = 0 - mang[i];
            //        //Console.WriteLine(" " +mang[i]);
            //        int TongGiaTriAm = mang[i];
            //        tong1 = tong1 + TongGiaTriAm;
            //    }
            //    else
            //    {
            //        int TongGiaTriDuong = mang[i];
            //        tong2 = tong2 + TongGiaTriDuong;
            //    }
            //    int sum = tong1 + tong2;
            //    Console.WriteLine("TongTriTuyetDoi: " + sum);
            //}

            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("phan tu " + i);
                mang[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                int giaTriTuyetDoi = mang[i];
                if (giaTriTuyetDoi < 0)
                {
                    giaTriTuyetDoi = giaTriTuyetDoi * -1;
                }
                tong = tong + giaTriTuyetDoi;
            }

            Console.WriteLine("Tong Gia tri tuyet doi: " + tong);
        }   
    }
}
