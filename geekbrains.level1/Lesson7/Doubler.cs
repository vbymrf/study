using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Doubler
    {
        internal static int NuberCommand;
        
        internal static int GenFinish;

        internal static int NowNumber=1;

       

        public static int Gen()
        {
            Random gena = new Random();
            GenFinish=gena.Next(10,100);

            return GenFinish;
        }
        

        internal static int NumberFinish(int geni)
        {
            int nam;
            return geni / 2 + geni%2;
            return geni;
        }
        internal static int NumberFinish2(int geni)        {
            if (geni == 2) return 1;
            return NumberFinish2(geni/2) / 2 + NumberFinish2(geni / 2) % 2;            
        }
    }
}
