using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalesTax
{
    public class CTransaction
    {
        //Private field
        private double tax;

        //Property
            public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        //Method

        public double CalculateSalesTax(double dblPrice)
        {
            return (dblPrice * 0.05);

        }


    }
}
