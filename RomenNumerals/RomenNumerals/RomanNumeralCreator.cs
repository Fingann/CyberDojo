using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace RomenNumerals
{
    public class RomanNumeralCreator
    {
        private static Dictionary<int, string> RomanDictionary { get; set; } = new Dictionary<int, string>
        {
            {0, ""},{1, "I"},
            {2, "II"}, {3, "III"},
            {4, "IV"}, {5, "V"},
            {6, "VI"}, {7, "VII"},
            {8, "VIII"}, {9, "IX"},
            {10, "X"}, {20, "XX"},
            {30, "XXX"}, {40, "XL"},
            {50, "L"}, {60, "LX"},
            {70, "LXX"}, {80, "LXXX"},
            {90, "XC"}, {100, "C"},
            {200, "CC"}, {300, "CCC"},
            {400, "CD"}, {500, "D"},
            {600, "DC"}, {700, "DCC"},
            {800, "DCCC"}, {900, "CM"},
            {1000, "M"}, {2000, "MM"},
            {3000, "MMM"}, {4000, "MMMM"}
        };

        public static string Convert(int number)
        {
            var potenses = NumberToPotenses.GetPotenses(number);
            string numerals = string.Empty;
            for (int i = potenses.Length -1; i >= 0; i--)
            {
                RomanDictionary.TryGetValue(potenses[i], out string numeral);
                numerals += numeral;
            }
            return numerals;
        }
    }
}