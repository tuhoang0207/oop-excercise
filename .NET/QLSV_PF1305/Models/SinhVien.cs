using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class SinhVien
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateOnly birthday{ get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string state { get; set; }
    }
}