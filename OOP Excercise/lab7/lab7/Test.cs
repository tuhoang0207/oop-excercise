using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Test
    {
        public static void Main(string[] args) { 
            MovablePoint m = new MovablePoint();
            m.moveLeft();
            m.moveRight();
            m.moveUp();
        }
    }
}
