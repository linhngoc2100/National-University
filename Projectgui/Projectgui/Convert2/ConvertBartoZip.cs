using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgui.Convert2
{
    public class ConvertBartoZip
    {
        public static string convertToZipCode(string barCode)
        {

            int count = 0;
            StringBuilder sb = new StringBuilder();
            int[,] binaryCodeN = new int[10, 5];
            String[,] barArray = new String[10, 5];
            barCode = barCode.Substring(1);     //Remove start bar
            barCode = barCode.Remove(barCode.Length - 1);//Remove Stop bar
            //loop the barcode to convert to binary number 1 and 0
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    String s1 = barCode.Substring(count, 1);

                    if (s1.Equals("|"))
                        binaryCodeN[i, j] = 1;
                    else
                        binaryCodeN[i, j] = 0;
                    count++;
                }
            }
            // convert binary number to digit number by using the rule 74210
            for (int k = 0; k < 10; k++)
            {
                int sum = 0;
                for (int l = 0; l < 5; l++)
                {
                    //get zero digit
                    if (binaryCodeN[k, 0] == 1 && binaryCodeN[k, 1] == 1)
                    {
                        sum = 0;
                        break;
                    }
                    //get other digits
                    else
                    {
                        
                        if (l == 0)
                        {
                            sum = sum + binaryCodeN[k, l] * 7;
                        }
                        else if (l == 1)
                            sum = sum + binaryCodeN[k, l] * 4;
                        else if (l == 2)
                            sum = sum + binaryCodeN[k, l] * 2;
                        else if (l == 3)
                            sum = sum + binaryCodeN[k, l] * 1;
                        else
                            sum = sum + binaryCodeN[k, l] * 0;
                    }
                }
                //add the number to string
                sb.Append(sum);
            }
            sb.Length--;
            //add -
            sb.Insert(5, " - ");
            return sb.ToString();
        }
    }
}
