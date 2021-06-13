using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            Hinh hinh1 = new HinhVuong() { Canh = 5.0f };
            Console.WriteLine("Dien tich hinh vuong la : {0:F1}", hinh1.GetArea());
            Hinh hinh2 = new HinhTamGiac() { CanhDay =9.0f, ChieuCao = 5.0f };
            Console.WriteLine("Dien tich hinh tam giac la: {0:F1}", hinh2.GetArea());

            Console.ReadKey();
        }
    }
}
