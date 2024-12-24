using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Core.Helpers
{
    public static class CalcBMI
    {
        public static double CalculateBMI(double weight,double height)
{
            return weight / (height * height);

        }
    }
}
