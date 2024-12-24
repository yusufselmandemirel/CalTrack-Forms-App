using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Core.Helpers
{
    public static class Ages
    {
        public static int CalculateAge(DateTime datetime)
        {
            return DateTime.Now.Year - datetime.Year;
        }
    }
}
