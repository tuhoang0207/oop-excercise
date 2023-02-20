using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class MonHoc
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string semester { get; set; }
        public int officeHours { get; set; }
        public string describe { get; set; }
        public string state { get; set; }
    }
}