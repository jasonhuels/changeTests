using System;
using System.Collections.Generic;

namespace Coins
{
    public class ChangeMaker
    {

        public static int[] CalculateChange(double total, double payment)
        {
            string[] changeType = {"quarters", "dimes", "nickles", "pennies"};
            int[] changeQuantity = {0, 0, 0, 0};
            int changeInt= (int)(payment*100)- (int)(total*100);
            Console.WriteLine(changeInt);
            
            if(changeInt >= 25)
            {
                changeQuantity[0] = changeInt / 25;
                changeInt -=  changeQuantity[0]*25;
            }
            if (changeInt >= 10)
            {
                changeQuantity[1] = changeInt / 10;
                changeInt -=  changeQuantity[1]*10;
            }
            if (changeInt >= 5)
            {
                changeQuantity[2] = changeInt / 5;
                changeInt -=  changeQuantity[2]*5;
            }
                     
            changeQuantity[3] = changeInt;
            return changeQuantity;
        }
    }
}