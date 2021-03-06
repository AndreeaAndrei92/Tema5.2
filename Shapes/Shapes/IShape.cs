﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class IShape
    {
        protected double width { get; set; }
        protected double height { get; set; }
        public IShape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public abstract double CalculateSurface();

    }
}

