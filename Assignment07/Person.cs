using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    abstract class Person
    {
        private string hoTen;
        private DateTime ngaySinh;
        private string queQuan;
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public abstract Person Nhap();
        public abstract void In();
    }
}
