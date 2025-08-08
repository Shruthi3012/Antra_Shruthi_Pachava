using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    internal class Ball
    {
    
       public int Size { get; set; }
       
        public Color Color { get; set; }
        public int TimeThrown { get; set; }


        public Ball(int size, Color color)
        {
            this.Size = size;
            this.Color = color;
            TimeThrown = 0;
        }
        public void Pop()
        {
            Size = 0;
        }
        public void Throw()
        {
            if (Size != 0)
                TimeThrown++;
        }

        public int GetTimeThrown()
        {
            return TimeThrown;
        }

    }
}
