using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class GiangVien
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateOnly birthday { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string majors { get; set; }
        public int salary { get; set; }
        public int bonus { get; set; }
        public string state { get; set; }
    }
}