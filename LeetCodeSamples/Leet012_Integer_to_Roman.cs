using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet012_Integer_to_Roman
    {
        public string IntToRoman(int num)
        {
            int thousand = num / 1000;
            int hundred = (num - thousand * 1000) / 100;
            int ten = (num - thousand * 1000 - hundred * 100) / 10;
            int n = num % 10;
            string roma = "";
            while (thousand > 0)
            {
                roma += "M";
                thousand--;
            }
            if (hundred < 4)
            {
                while (hundred > 0)
                {
                    roma += "C";
                    hundred--;
                }
            }
            else if (hundred == 4)
            {
                roma += "CD";
            }
            else if (hundred == 5)
            {
                roma += "D";
            }
            else if (hundred < 9)
            {
                roma += "D";
                while (hundred - 5 > 0)
                {
                    roma += "C";
                    hundred--;
                }
            }
            else
            {
                roma += "CM";
            }

            if (ten < 4)
            {
                while (ten > 0)
                {
                    roma += "X";
                    ten--;
                }
            }
            else if (ten == 4)
            {
                roma += "XL";
            }
            else if (ten == 5)
            {
                roma += "L";
            }
            else if (ten < 9)
            {
                roma += "L";
                while (ten - 5 > 0)
                {
                    roma += "X";
                    ten--;
                }
            }
            else
            {
                roma += "XC";
            }

            if (n > 0)
            {
                switch (n)
                {
                    case 1:
                        roma += "I";
                        break;
                    case 2:
                        roma += "II";
                        break;
                    case 3:
                        roma += "III";
                        break;
                    case 4:
                        roma += "IV";
                        break;
                    case 5:
                        roma += "V";
                        break;
                    case 6:
                        roma += "VI";
                        break;
                    case 7:
                        roma += "VII";
                        break;
                    case 8:
                        roma += "VIII";
                        break;
                    case 9:
                        roma += "IX";
                        break;
                }
            }

            return roma;
        }
    }
}
