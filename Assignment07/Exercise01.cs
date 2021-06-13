using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    class Baitap01
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[4];
            people[0] = new CongNhan() { HoTen = "Nguyen Thi Lan", NgaySinh = Convert.ToDateTime("1993/08/25"), NgheNghiep = "Cong nhan", QueQuan = "Ha Nam", MucThuNhap = 1000 };
            people[1] = new HocSinh() { HoTen = "Nguyen Van An", NgaySinh = Convert.ToDateTime("2004/07/04"), QueQuan = "Hai Phong", TenLop = "11A", DiemTrungBinh = 8.5f };
            people[2] = new CongNhan() { HoTen = "Bui Thi Xuan", NgaySinh = Convert.ToDateTime("1990/08/03"), NgheNghiep = "Giao Vien", QueQuan = "Ha Noi", MucThuNhap = 1500 };
            people[3] = new HocSinh() { HoTen = "Nguyen Van Nam", NgaySinh = Convert.ToDateTime("2005/11/17"), QueQuan = "Hai Phong", TenLop = "10B", DiemTrungBinh = 7.5f };
            Console.WriteLine("Danh sach cong nhan: ");
            foreach (var person in people)
            {
                if (person is CongNhan)
                {
                    person.In();
                }
            }
            Console.WriteLine("Danh sach hoc sinh: ");
            foreach (var person in people)
            {
                if (person is HocSinh)
                {
                    person.In();
                }
            }

            Console.ReadKey();
        }
    }
}
