using System;

namespace MyFirstProject
{
    class baitap1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------CHuong Trinh Tinh 2 So-----------");
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap Phep Tinh(+,-,*,/): ");
            char pheptinh = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double ketqua = 0;

            switch (pheptinh) {
                case '+': ketqua = a + b;
                    break;
                case '-':
                    ketqua = a - b;
                    break;
                case '*':
                    ketqua = a * b;
                    break;
                case '/':
                    if (b != 0) {
                        ketqua = (double)a / b;
                        
                    }

                    else
                    {
                        Console.WriteLine("Khong ton tai phep chia 0");
                        return;
                    }
                    break;

                default: Console.WriteLine("Phep tinh khong hop le");
                    return;
                    

            }
            Console.WriteLine($"Ket Qua: {ketqua}");
        }
    }
}