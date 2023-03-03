using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignment.Interfaces
{
    internal interface ILibrary
    {
        public void addNew();
        public void show();
        public void update();
        public void delete();

        public void sort();
        public void search();
        public void analyze();
        public void saveToFile();
    }
}
