using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class QuanlyCD
    {
        private CD[] ds;
        private int n;

        public QuanlyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanlyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("danh sach da day.");
            }
            else
            {
                if (!kiemTraTrungCD(cd.MACD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");

                }
            }
           
        }
        private bool kiemTraTrungCD(int macd)
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].MACD == macd)
                {
                    return true;
                }
            }
            return false;
        }
        public double tinhGiaTB()
        {
            int tonggia = 0;
            for (int i = 0; i < n; i++)
            {
                tonggia += ds[i].DongGia;
            }
            return (double)tonggia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1,30} {2, 30} {3, 10} {4,15}",
                "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].Tostring());
            }
        }
        public void SapxepGiamThemGiaThanh()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].DongGia < ds[i].DongGia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
