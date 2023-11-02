using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практ5
{
    internal class CheckArray
    {
        static public bool CheckAlternatingCase(char[] array)
        {
            bool isLower = Char.IsLower(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (isLower && Char.IsLower(array[i]))
                {
                    return false;
                }
                else if (!isLower && Char.IsUpper(array[i]))
                {
                    return false;
                }

                isLower = !isLower;
            }
            return true;
        }
    }
}
