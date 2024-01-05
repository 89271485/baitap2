﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanlyCD quanlyCD = new QuanlyCD(3);
            int chon = 0;
            do
            {
                Console.WriteLine("**********Chuong trinh quan ly CD*************");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh binh");
                Console.WriteLine("3. Sap xep CD giam dan them gia thanh");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat chuong trinh.");
                Console.WriteLine("--------------------------------------------");
                Console.Write("ban chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma cd:");
                        cd.MACD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si:");
                        cd.Casi = Console.ReadLine();
                        Console.Write("Nhap so bai hat:");
                        cd.SoBaiHat = int.Parse( Console.ReadLine());
                        Console.Write("Nhap gia thanh:");
                        cd.DongGia = int.Parse(Console.ReadLine());
                        quanlyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanlyCD.tinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh : (0: #,##0.00)", kq);
                        break;
                    case 3:
                        quanlyCD.SapxepGiamThemGiaThanh();
                        Console.WriteLine("Da sap them gia thanh giam dan");
                        break;
                    case 4:
                        break;
                    case 5:
                        quanlyCD.Xuat();
                        break;
                   
                }
            }while (chon != 0);
        }
    }
}
