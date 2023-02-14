using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt11_12_zad2
{
    class Vektor
    {
        public int firstv1;
        public int firstv2;
        public int firstv3;
        public int secondv1;
        public int secondv2;
        public int secondv3;
       
        public int summa1()
        {
            int sum1 = firstv1 + secondv1;
            
            return sum1;
        }
        public int summa2()
        {
            int sum2 = firstv2 + secondv2;
            return sum2;
        }
        public int summa3()
        {
            int sum3 = firstv3 + secondv3;
            return sum3;
        }
        public int minus1()
        {
            int min1 = secondv1 - firstv1;
            return min1;
        }
        public int minus2()
        {
            int min2 = secondv2 - firstv2;
            return min2;
        }
        public int minus3()
        {
            int min3 = secondv3 - firstv3;
            return min3;
        }
        public int dlina1()
        {
            int dlina1 = (int)Math.Sqrt(Math.Pow(firstv1, 2) + Math.Pow(firstv2, 2) + Math.Pow(firstv3, 2));
            return dlina1;
        }
        public int dlina2()
        {
            int dlina2 = (int)Math.Sqrt(Math.Pow(secondv1, 2) + Math.Pow(secondv2, 2) + Math.Pow(secondv3, 2));
            return dlina2;
        }
        public int ygol()
        {
            int sc = firstv1 * secondv1 + firstv2 * secondv2 + firstv3 * secondv3;
            int modul1 = (int)Math.Sqrt(Math.Pow(firstv1, 2) + Math.Pow(firstv2, 2) + Math.Pow(firstv3, 2));
            int modul2 = (int)Math.Sqrt(Math.Pow(secondv1, 2) + Math.Pow(secondv2, 2) + Math.Pow(secondv3, 2));
            int yg = sc / modul1 * modul2;

            return yg;
        }
        public int scal9r()
        {
            int sc = firstv1 * secondv1 + firstv2 * secondv2 + firstv3 * secondv3;
            return sc;
        }
    }
}
