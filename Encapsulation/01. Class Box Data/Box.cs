using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Encapsulation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
     	
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ZeroOrNegativeValidation("Length",value);

                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ZeroOrNegativeValidation("Width",value);

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ZeroOrNegativeValidation("Height",value);
                this.height = value;
            }
        }

        private void ZeroOrNegativeValidation(string name, double value)
        {            
            if (value <= 0)
            {
                throw new ArgumentException($"{name} cannot be zero or negative.");
            }            
        }

        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }

        public double Volume()
        {
            return length * width * height;
        }
    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {this.SurfaceArea() :F2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea() :F2}");
            sb.AppendLine($"Volume - {this.Volume() :F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
