using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet007_Reverse_Integer
    {
        public int Reverse_Integer(int val)
        {

            int result = 0;
            while (true)
            {
                int dig = val % 10;
                if (dig == 0)
                    break;
                val = val / 10;
                result = result * 10 + dig;

            }
            return result;
        }

        public int Reverse_Integer_Default(int val)
        {

            long result = 0;
            while (val != 0)
            {
                result = result * 10 + val % 10;
                val = val / 10;
            }

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new ArgumentOutOfRangeException("result out of int range");
            }
            return (int)result;
        }

    }

}
