using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : IShape
    {
        public Square(double r)
            : base(r, r)
        {

        }

        public override double CalculateSurface()
        {
            return Math.PI * this.width / 2 * this.height / 2;
        }
    }
}
