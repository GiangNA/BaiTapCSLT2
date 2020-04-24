using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSV htttak21 = new DanhSachSV();
            htttak21.Nhap();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            Console.ReadLine();
        }
    }
}
