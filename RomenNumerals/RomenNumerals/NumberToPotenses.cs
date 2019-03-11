using System;
using System.Collections.Generic;

namespace RomenNumerals
{
    public class NumberToPotenses
    { 
        
        public static int[] GetPotenses(int number)
        {
            int numberOfPotenses = number.ToString().Length;
            
            int[] potens = new int[numberOfPotenses];
            int aggregatedSum = 0;
            int modulu = 10;
            
            for (int i = 0; i < numberOfPotenses; i++)
            {
                potens[i] = number % modulu - aggregatedSum;
                aggregatedSum += potens[i];
                modulu *= 10;
            }
            return potens;
        }
    }
}