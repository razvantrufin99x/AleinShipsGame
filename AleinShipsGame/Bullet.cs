using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleinShipsGame
{
    public  class Bullet
    {
        public int x;
        public int y;
        public Color color;
        public float width;
        public float height;
        public Bullet() { }
        public Bullet(int px, int py, Color pcolor, float pw, float ph)
        {
            x = px;
            y = py;
            color = pcolor;
            width = pw;
            height = ph;

        }
    }
}
