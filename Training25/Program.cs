// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T02: Number to words and Roman numeral converter.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   // Converts a number to words,upto number 9999999.
   static string NumToWords (int inp) {
      if (inp == 0) return "Zero";
      string[] ones = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                             "Nine","Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
      string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
                                 "Eighty", "Ninety"};
      String result = "";
      int lakhs = inp / 100000;
      if (lakhs > 0) {
         result += NumToWords (lakhs) + "Lakh ";
         inp %= 100000;
      }
      int thousands = inp / 1000;
      if (thousands > 0) {
         result += NumToWords (thousands) + "Thousand ";
         inp %= 1000;
      }
      int hundreds = inp / 100;
      if (hundreds > 0) {
         result += NumToWords (hundreds) + "Hundred ";
         inp %= 100;
         if (inp > 0) result += "and ";
      }
      if (inp >= 20) {
         result += tens[inp / 10] + " ";
         inp %= 10;
      }
      if (inp < 20) result += ones[inp] + " ";
      return result;
   }

   // Converts a number to its equivalent Roman numeral,upto number 3999.
   static string RomNumConv (int inp) {
      string result = "";
      Dictionary<int, string> romNum = new () {
         {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
         {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
         {10, "X"}, {9, "IX"}, {8, "VIII"}, {7, "VII"}, {6, "VI"}, {5, "V"}, {4, "IV"},
         {3, "III"}, {2, "II"}, {1, "I"},
       };
      foreach (var item in romNum) {
         while (inp >= item.Key) {
            result += item.Value;
            inp -= item.Key;
         }
      }
      return result;
   }

   static void Main () {
      int inpChoice, inp;
      string result = "";
      bool isVal = false;
      do WriteLine ("What do you want to convert?\n1.Number to words\n2.Number to Roman numeral");
      while (!int.TryParse (ReadLine (), out inpChoice) || (inpChoice != 1 && inpChoice != 2));
      switch (inpChoice) {
         case 1:
            while (!isVal) {
               Write ("Enter a number less than 1 crore: ");
               isVal = int.TryParse (ReadLine (), out inp) && inp >= 0 && inp <= 9999999;
               if (isVal) {
                  result = NumToWords (inp);
                  Write ($"The word representation for the given input {inp} is: ");
               } // After 1 crore the wordings are not correct
               else if (inp < 0 || inp > 9999999) isVal = false;
            }
            break;
         case 2:
            while (!isVal) {
               Write ("Enter a number between 1 to 3999: ");
               isVal = (int.TryParse (ReadLine (), out inp)) && (inp > 0 && inp < 4000);
               if (isVal) {
                  result = RomNumConv (inp);
                  Write ($"The Roman numeral for the given input {inp} is: ");
               }// There are no Roman numerals for 0 and negative numbers and >3999
               else if ((inp < 1 || inp > 3999)) isVal = false;
            }
            break;
      }
      if (isVal) { // To display the result in green color common for both conversions.                                                                    
         ForegroundColor = ConsoleColor.Green;
         Write (result);
         ResetColor ();
      }
   }
}