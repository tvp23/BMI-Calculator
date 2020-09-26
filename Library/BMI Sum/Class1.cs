using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Sum
{
    public class Class1
    {
        public double Sum(double kgv, double lenvm, double lenv, double lenv2, double output, double sum)
        {
            lenvm = lenv / 10 / 10;
            lenv2 = lenvm * lenvm;
            sum = kgv / lenv2;
            return sum;
        }
    }
}
