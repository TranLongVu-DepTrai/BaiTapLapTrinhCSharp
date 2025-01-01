using System;
using System.Linq.Expressions;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tro Choi Doan So Trung Thuong");
            Console.WriteLine("Ban co the nhap 7 lan de kiem tra");

            Random random = new Random();
            int soTrungThuong = random.Next(1, 101);
            int soLanDoan = 7;
            bool daDoanDung = false;
            try
            {
                for (int i = 1; i <= soLanDoan; i++)
                {
                    Console.Write("Nhap so du doan: ");
                    int soDuDoan = int.Parse(Console.ReadLine());


                    if (soDuDoan == soTrungThuong)
                    {
                        Console.WriteLine("Chuc Mung , ban da trung thuong!");
                        Console.WriteLine("---------------------");
                        daDoanDung = true;
                        break;
                    }

                    else if (soDuDoan < soTrungThuong)
                    {
                        Console.WriteLine("So ban nhap be hon so trung thuong!");
                        Console.WriteLine("---------------------");
                    }
                    else
                    {
                        Console.WriteLine("So ban nhap lon hon so trung thuong");
                        Console.WriteLine("---------------------");
                    }
                }

                if (!daDoanDung)
                {
                    Console.WriteLine("Rat tiec , ban da het co hoi du doan!");
                    Console.WriteLine($"So trung thuong la {soTrungThuong}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi , vui long nhap so nguyen");
            }
        }
    }
}