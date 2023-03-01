using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise3lab7
{
    public interface ILibrary
    {
        public void addNew();
        public void show();
        public void update();
        public void delete();

        public void sort();
        public void search();

        public void saveToFile();
    }
}
