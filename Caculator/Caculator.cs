﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    class Caculator
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("============= MY CACULATOR =============");
                Console.WriteLine("1. Cong hai so.");
                Console.WriteLine("2. Tru hai so.");
                Console.WriteLine("3. Nhan hai so.");
                Console.WriteLine("4. Chia hai so.");
                Console.WriteLine("5. Chia lay du hai so.");
                Console.WriteLine("6. Tinh a^b.");
                Console.WriteLine("0. Thoat.");
                Console.WriteLine("Ban chon?");

                string input = Console.ReadLine();
                choice = Convert.ToInt32(input);
                int a = default, b = 0;

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("======= HEN GAP LAI =======");
                        break;

                    case 1:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;

                    case 2:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;

                    case 4:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if(b == 0)
                        {
                            Console.WriteLine("Nhap mau so khac 0!");
                            continue;
                        }
                        Console.WriteLine($"{a} / {b} = {1.0f*a / b}");
                        break;

                    case 5:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b == 0)
                        {
                            Console.WriteLine("Nhap mau so khac 0!");
                            continue;
                        }
                        Console.WriteLine($"{a} % {b} = {a % b}");
                        break;

                    case 6:
                        Console.WriteLine("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
                        break;

                    default:
                        Console.WriteLine("Nhap dung chuc nang (0 - 6).");
                        break;
                }
            } while (choice != 0);
        }
    }
}