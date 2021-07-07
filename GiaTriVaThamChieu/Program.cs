using System;

namespace GiaTriVaThamChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int, long, float, double, decimal, enum (char) => kieu du lieu gia tri
            //// bool =>
            //// struct => 

            //string harryPorterFull = "x";

            //// class => tham chieu

            //int a = 1;
            //Int32 b = 1;
            //long c = 100; // (Int64)


            //int a = 1;
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //b = 2;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            NhanVien nv1 = new NhanVien();// => bien tham chieu 12345
            nv1.Ten = "dan nguyen";
            nv1.Tuoi = 30;
            nv1.DiaChi = "thai nguyen";

            NhanVien nv2 = nv1;
            NhanVien nv3 = nv1;

            Console.WriteLine(nv1.Ten);
            Console.WriteLine(nv2.Ten);

            nv2.Ten = "Do phong";

            Console.WriteLine(nv1.Ten);
            Console.WriteLine(nv2.Ten);
            Console.WriteLine(nv3.Ten);


            NhanVien nv4 = new NhanVien();


        }
    }

    class NhanVien
    {
        public string Ten;
        public int Tuoi;
        public string DiaChi;

    }
}
