using System;
public struct stl
{
    public string ten;
    public int maso;
}
    class Program
    {
        static void Main(string[] args)
        {
        stl p; //khai bao bien
            p.ten = "Phong";
            p.maso = 68;
        Console.WriteLine("Ten: "+p.ten);
        Console.WriteLine("Maso: "+p.maso);
        }
    }
