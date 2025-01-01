using System;


namespace BaiTap2_LapTrinhWebNangCao
{
    class Baitap2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Chuong trinh giai phuong trinh bac 2------------------");

            try
            {
                Console.Write("Nhap He So a: ");
                double a = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("He so a phai khac 0");
                    return;
                }

                Console.Write("Nhap he so b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Nhap he so c: ");
                double c = double.Parse(Console.ReadLine());

                double delta = b * b - 4 * a * c;


                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                    return;
                }

                else if (delta == 0)
                {
                    double x = (-b) / 2 * a;
                    Console.WriteLine($"Phương trình có nghiệm kép x1=x2={x}");
                    return;
                }

                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                    return;
                }
            }

            catch (Exception e) {
                Console.WriteLine("Loi: He so khong hop le!!!");
            }

        }
    }
}
