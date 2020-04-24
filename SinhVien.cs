using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_Bai6
{
    class SinhVien
    {
        //mã sinh viên, Họ tên, Điểm lập trình, Điểm CSDL, Điểm TB. trong đó Điểm TB = (Điểm LT + Điểm CSDL)/2
        public string masv;
        private string HoTen;
        private int NamSinh;
        private double DiemLT, DiemCSDL, DiemTB;

        // ham khoi tao khong tham so

        public SinhVien()
        {
            masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;

        }

        // ham khoi tao chua 5 tham so

        public SinhVien(string masv, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLT + DiemCSDL) / 2;
        }

        public void Nhap()
        {
            Console.WriteLine("Hay nhap vao ho ten cua sinh vien:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap ma cua sinh vien:");
            masv = Console.ReadLine();
            Console.WriteLine("Hay nhap vao nam sinh cua sinh vien:");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap Diem LT cua sinh vien:");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap vao Diem CSDL cua sinh vien:");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten cua sinh vien la: " + HoTen);
            Console.WriteLine("ma cua sinh vien la: " + masv);
            Console.WriteLine("Nam sinh cua sinh vien la: " + NamSinh);
            Console.WriteLine("Diem LT cua sinh vien la: " + DiemLT);
            Console.WriteLine("Diem CSDL cua sinh vien la: " + DiemCSDL);
            Console.WriteLine("Diem TB cua sinh vien la: " + DiemTB);
        }

    }
}
