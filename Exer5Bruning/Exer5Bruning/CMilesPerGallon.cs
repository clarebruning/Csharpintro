using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5Bruning
{
    public class CMilesPerGallon
    {
        private double mpg;

        public double MPG
        {
            get { return mpg; }
            set { mpg = value; }
        }

        public double CalculateMilesPerGallon(double dblMiles, double dblGallons)
        {
            return Math.Round((dblMiles / dblGallons), 2);
        }
    }
}
