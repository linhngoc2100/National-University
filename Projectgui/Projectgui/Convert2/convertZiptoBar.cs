using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgui.Convert2
{
    class convertZiptoBar
    {
        //set start and stop bar
        static string startstopbar = "|";
        //array of binary code for Barcode
        static int[,] binaryBarcode = new int[10, 5] {
            {1, 1, 0, 0, 0} ,   /*  initializers for row indexed by 0 */
            {0, 0, 0, 1, 1} ,   /*  initializers for row indexed by 1 */
            {0, 0, 1, 0, 1} ,  /*  initializers for row indexed by 2 */
            {0, 0, 1, 1, 0} ,  /*  initializers for row indexed by 3 */
            {0, 1, 0, 0, 1} ,  /*  initializers for row indexed by 4 */
            {0, 1, 0, 1, 0} ,  /*  initializers for row indexed by 5 */
            {0, 1, 1, 0, 0} ,  /*  initializers for row indexed by 6 */
            {1, 0, 0, 0, 1} ,  /*  initializers for row indexed by 7 */
            {1, 0, 0, 1, 0} ,  /*  initializers for row indexed by 8 */
            {1, 0, 1, 0, 0}   /*  initializers for row indexed by 9 */
    };
        //method for convert from Zipcode to Barcode
        public static string convertToBarCode(string zipCode)
        {
            zipCode = zipCode.Trim();//remove empty space

            int zip = Int32.Parse(zipCode);//convert from string to Integer
            int sum = 0;
            StringBuilder barCode = new StringBuilder();
            int zipDigit = 0; 
            Stack<int> myStack = new Stack<int>();//stack to store the digit of zipcode
            while (zip > 0)
            {
                myStack.Push(zip % 10);//push the remainder after division to stack
                sum = sum + (zip % 10);//get new sum 
                zip = zip / 10;

            }
            //while loop to pop the stack
            while (myStack.Count > 0)
            {
                //pop the top first
                zipDigit = myStack.Pop();
                //get barcode
                barCode.Append(getBar(zipDigit));
                /*
                for (int j = 0; j < 5; j++)
                {
                    //condition check to see if the number is 1 or 0 for setting | or :
                    if (binaryBarcode[zipDigit, j] == 1)
                        barCode.Append("|");
                    else
                        barCode.Append(":");
                }*/

            }
            //calculate checkDigit
            int checkDigit;
            if (sum % 10 == 0)
                checkDigit = 0;
            else
                checkDigit = 10 - (sum % 10);
            //convert barCode from stringbuilder to string
            string s = barCode.ToString();
            //set the barCode with start and stop bar and check digit
            s = startstopbar + s + getBar(checkDigit) + startstopbar;
            return s;
        }
        //get the barcode method
        public static string getBar(int x)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < 5; j++)
            {
                if (binaryBarcode[x, j] == 1)
                    sb.Append("|");
                else
                    sb.Append(":");

            }
            return sb.ToString();
        }
    }
}
