using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class Array
    {
        public static int[] Incremento_1(int[] a)
        {
            int[] array1 = new int[5];

            for(int i=0 ; i<a.Length ; i++)
            {
                array1[i] = a[i]+10;
            }

            return array1;
        }
    }
}
