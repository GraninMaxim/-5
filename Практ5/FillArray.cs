using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практ5
{
    internal  class FillArray
    {
        static public char[] FillArray1(char[] array,Random rnd)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)rnd.Next(71, 123);
            }
            return array;
        }
    }
}
