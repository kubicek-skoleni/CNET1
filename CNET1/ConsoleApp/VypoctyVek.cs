using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VypoctyVek
    {
        public static int Age(DateTime birth)
        {
            DateTime now = DateTime.Now;

            TimeSpan diff = now - birth;

            return (int)(diff.TotalDays / 365);
        }
    }
}
