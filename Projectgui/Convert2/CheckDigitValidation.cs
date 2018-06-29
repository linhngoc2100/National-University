﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectgui.Convert2
{
    class CheckDigitValidation
    {
        public static Boolean CheckandValidation(string barCode)
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();
            int sum1 = 0;
            int[,] binaryCodeN = new int[10, 5];
            String[,] barArray = new String[10, 5];

            //validation of first and last bar as |
            if (((barCode.StartsWith("|"))) && ((barCode.EndsWith("|"))))
            {
                barCode = barCode.Substring(1);     //Remove start bar
                barCode = barCode.Remove(barCode.Length - 1);//Remove Stop bar           
                //convert barcode to binary number 0 and 1
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
                //get the digit for every 5 binary number
                for (int k = 0; k < 10; k++)
                {
                    int sum = 0;
                    for (int l = 0; l < 5; l++)
                    {

                        if (binaryCodeN[k, 0] == 1 && binaryCodeN[k, 1] == 1 && binaryCodeN[k, 2] == 0 && binaryCodeN[k, 3] == 0 && binaryCodeN[k, 4] == 0)
                        {
                            sum = 0;
                            break;
                        }
                        //if the 5 binary number is 00000, it will return error message
                        else if (binaryCodeN[k, 0] == 0 && binaryCodeN[k, 1] == 0 && binaryCodeN[k, 2] == 0 && binaryCodeN[k, 3] == 0 && binaryCodeN[k, 4] == 0)
                            return false;
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
                    //if the digit is greater than 9, it will show error message
                    if(sum>9)
                    {
                        /*MessageBox.Show("Barcode not in correct format", "Barcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                        return false;
                    }
                    else
                        sum1 = sum1 + sum;

                }
                //debug the sum in console output
                Debug.WriteLine(sum1);
                if (sum1 % 10 == 0)
                    return true;
                else
                    return false;
                
            }
            else
            {
                /*MessageBox.Show("Barcode not in correct format", "Barcode input error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                return false;
            }
            
        }
    
    }
}
