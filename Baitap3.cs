using System;
using System.Linq.Expressions;
using System.Net.Mail;

namespace Baitap3_Laptrinhwebnangcao
{
    class Baitap3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Chuong Trinh Kiem Tra So Nguyen To---------------");

            try { 

            int n;
            do
            {
                Console.Write("Nhap so nguyen n (n>=2): ");
                n = int.Parse(Console.ReadLine());

                if (n < 2) Console.WriteLine("Nhap sai, vui long nhap lai!");
            }
            while (n < 2);



            if (kiemtrasonguyento(n))
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }

        }
                catch(Exception ex) {
                Console.WriteLine("Vui long nhap so nguyen");
            }


            }

        static Boolean kiemtrasonguyento(int n)
            {
                if (n == 1) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }
        }

        

    }
