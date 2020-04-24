using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_Bai6
{
    class DanhSachSV
    {
        private int n;
        private SinhVien[] DS;

        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach:");
            n = Convert.ToInt32(Console.ReadLine());

            DS = new SinhVien[n];

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("hay nhap thong tin Sinh Vien thu" + i);
                DS[i] = new SinhVien();
                DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            if (DS != null && n>0)
            {
                for (int i=0; i<n; i++)
                {
                    DS[i].Xuat();
                }
            }
        }

        public void SapXep() // sap xep ma sv tang dan
        {
            for (int i=0; i<n-1; i++)
                for (int j=0; j<n; j++)
                {
                    if (string.Compare(DS[i].masv, DS[j].masv, true) >0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }

                }
        }
    }
}
