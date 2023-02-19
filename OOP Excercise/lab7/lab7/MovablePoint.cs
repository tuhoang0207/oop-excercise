﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class MovablePoint : IMovable
    {
        public int x;
        public int y;

        public void moveDown()
        {
            y--;
        }

        public void moveLeft()
        {
            x--;
        }

        public void moveRight()
        {
            x++;
        }

        public void moveUp()
        {
            y++;
        }
    }
}
