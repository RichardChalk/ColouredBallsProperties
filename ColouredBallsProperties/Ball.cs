using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredBalls
{
    public class Ball
    {
        public Colour Colour { get; set; }
        public float Size { get; set; }
        public int TimesThrown { get; private set; }

        public Ball(Colour colour, float size)
        {
            Colour = colour;
            Size = size;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                TimesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return TimesThrown;
        }
    }
}
