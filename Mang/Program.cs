using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] phantu = new int[100];

            int n, i, j, temp;

            // Khai bao so luong phan tu mang tu ban phim
            Console.WriteLine("Nhap vao so luong phan tu");
            n = int.Parse(Console.ReadLine());
            // Nhap cac gia tri vao mang
            Console.WriteLine("nhap {0} phan tu vao trong mang: ", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("phan tu - {0}: ", i);
                phantu[i] = int.Parse(Console.ReadLine());
            }
            // xap xep tang dan
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (phantu[i] > phantu[j])
                    {
                        temp = phantu[i];
                        phantu[i] = phantu[j];
                        phantu[j] = temp;
                    }
                }
            }

            Console.WriteLine("In mang sau khi xap xep tang dan");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", phantu[i]);
            }


            // Xap xep giam dan
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (phantu[i] < phantu[j])
                    {
                        temp = phantu[i];
                        phantu[i] = phantu[j];
                        phantu[j] = temp;
                    }
                }
            }
            Console.WriteLine("In mang sau khi xap xep giam dan:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", phantu[i]);
            }
            Console.WriteLine(" ");

            // chia thanh 2 mang (mang chan, mang le) => in ra 2 mang [2,1,3]
            int[] soChan = new int[10];
            int soChanIndex = 0;
            int[] soLe = new int[10];
            int soLeIndex = 0;
            for (i = 0; i < n; i++)
            {
                int so = phantu[i];
                if (so % 2 == 0)
                {
                    //Console.WriteLine("phan tu chan:{0}", so);
                    soChan[soChanIndex] = so;
                    soChanIndex = soChanIndex + 1; // soChanIndex++;
                }
                else
                {
                    //Console.WriteLine("phan tu le:{0}", so);
                    soLe[soLeIndex] = so;
                    soLeIndex = soLeIndex + 1; //soLeIndex++;
                }
            }
            Console.WriteLine("Mang so chan la: ");
            for (i = 0; i < soChanIndex; i++)
            {
                Console.WriteLine("{0} ", soChan[i]);
            }
            Console.WriteLine("Mang so le la: ");
            for (i = 0; i < soLeIndex; i++)
            {
                Console.WriteLine("{0} ", soLe[i]);
            }
            Console.ReadKey();
        }
    }
}

// 1) Mang
// + nhap tu ban phim vao mang 10 phan tu
// + xap xep tang dan => in ra
// + xap xep giam dan => in ra mang da xap xep
// + chia thanh 2 mang (mang chan, mang le) => in ra 2 mang 
// + tinh trung binh cong cua mang
// + tinh tong cac gia tri tuyet doi cua cac phan tu
// + in ra danh sach cac phan tu la so nguyen to (so nguyen to la so chi chia het cho 1 va chinh no)
// + in ra min va max
// + them 1 phan tu co gia tri la trung binh cong cua mang vao vi tri thu 5

// 2) Vong lap
// Nhap vao 1 so tu nhien nguyen duong n
// + In ra tam giac co chieu cao n
//    *
//   ***
//  *****
// *******

//    *
//   * *
//  *   *
// *******
