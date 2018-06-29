using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgui.Convert
{
    class PostalBarCode
    {
        public static int CODE_SIZE = 9;
        static string startbar = "|";
        static string stopbar = "|";
        static string[] barcode = new string[10] { "||:::", ":::||", "::|:|", "::||:", ":|::|", ":|:|:", ":||::", "|:::|", "|::|:", "|:|::" };
        public static string convertToBarCode(string zipCode)
        {
            zipCode = zipCode.Trim();
            //zipCode = zipCode.Replace("-", "");
            int zip = Int32.Parse(zipCode);
            int sum = 0;
            string barCode = "";
            for (int i = 0; i < CODE_SIZE; i++)
            {
                int digit = zip % 10;
                sum += digit;
                barCode = getBar(digit) + barCode;
                zip /= 10;
            }
            int checkDigit = 10 - (sum % 10);
            barCode = startbar + barCode + getBar(checkDigit) + stopbar;
            return barCode;
        }

        public static string convertToZipCode(string barCode)
        {
            long zip = 0;
            barCode = barCode.Trim();
           barCode = barCode.Substring(1);     //Remove start bar

            
            for (int i = 0; i < CODE_SIZE; i++)
            {
                int digit = getDigit(barCode.Substring(i * 5, 5));
                zip = zip * 10 + digit;
            }
            string s = zip.ToString().Insert(5," - ");
            return s;
            
        }

        public static string getBar(int x)
        {
            return barcode[x];
        }

        public static int getDigit(string bar)
        {
            for (int i = 0; i < 10; i++)
            {
                if (bar == barcode[i])
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
