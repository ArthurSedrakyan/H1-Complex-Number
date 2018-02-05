using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public static class ComplexHelper
    {
        public static int Arg(this Complex c)
        {
            double z = c.Abs();
            double cos = Math.Cos(c.Real / z);
            double sin = Math.Sin(c.Lip / z);

            if (cos >= 0 && sin >= 0)
                return 1;

            if (cos <= 0 && sin <= 0)
                return 3;

            if (cos >= 0)
                return 4;

            return 2;
        }

        public static double Abs(this Complex c)
        {
            return Math.Sqrt(c.Real * c.Real + c.Lip * c.Lip);
        }
    }
}
