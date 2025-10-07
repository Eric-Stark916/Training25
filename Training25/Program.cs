// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T02 //This code is used to convert numbers to its equivalent words and Romanletters.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   /// <summary>convert nuber to words upto 9999999</summary>
   /// <param name="input">Takes whole number as input </param>
   /// <returns>words equivalent to the number entered</returns>
   static string NumberToWords (int input) {
      string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                             "Nine","Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen", };
      string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
                                 "Eighty", "Ninety" };
      String result = "";
      if (input == 0) return "Zero";
      if (input / 100000 > 0) {
         result += NumberToWords (input / 100000) + "Lakh ";
         input %= 100000;
      }
      if (input / 1000 > 0) {
         result += NumberToWords (input / 1000) + "Thousand ";
         input %= 1000;
      }
      if (input / 100 > 0) {
         result += NumberToWords (input / 100) + "Hundred ";
         input %= 100;
         if (input > 0) result += "and ";
         else result += "";
      }
      if (input >= 20) {
         result += tens[input / 10] + " ";
         input %= 10;
      }
      if (input < 20 && input > 0) result += ones[input] + " ";
      return result;
   }

   /// <summary> convert number to its equivalent roman letters upto 3999</summary>
   /// <param name="input">Takes Natural numbers as input from the user</param>
   /// <returns>Roman letters equivalent to the decimal</returns>
   static string RomanLetterConverter (int input) {
      string[] firstTen = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
      string result = "";
      if (input >= 1000) {
         result += new string ('M', input / 1000);
         input %= 1000;
      }
      if (input >= 900) {
         result += "CM";
         input -= 900;
      }
      if (input >= 500) {
         result += "D";
         input -= 500;
      }
      if (input >= 400) {
         result += "CD";
         input -= 400;
      }
      if ((input>=100)) {
         result += new string ('C', input / 100);
         input %= 100;
      }
      if (input >= 90) {
         result += "XC";
         input -= 90;
      }
      if (input >= 50) {
         result += "L";
         input -= 50;
      }
      if (input >= 40) {
         result += "XL";
         input -= 40;
      }
      if ((input >= 10)) {
         result += new string ('X', input / 10);
         input %= 10;
      }
      if (input <= 9) result += firstTen[input];
      return result;
   }

   static void Main () {
      int inputChoice, input;
      string result;
      bool isValid;
      do WriteLine ("What do you want to convert?\n1.Number to Words\n2.Number to Roman Letters");
      while (!int.TryParse (ReadLine (), out inputChoice) || (inputChoice != 1 && inputChoice != 2));
      if (inputChoice == 1) {
         do {
            WriteLine ("Enter a number less than 1 crore :");
            isValid = (int.TryParse (ReadLine (), out input) && (input >= 0 && input <= 9999999));
            if (isValid) {
               result = NumberToWords (input);
               Write ($"The word representation for the given input {input} is ");
               ForegroundColor = ConsoleColor.Green;
               Write (result);
               ResetColor ();
            } else WriteLine ("Invalid input, please enter a valid number.");
         } while (!isValid);
      }
      if (inputChoice == 2) {
         do {
            WriteLine ("Enter a number between 1 to 3999:");
            isValid = (int.TryParse (ReadLine (), out input) && (input > 0 && input < 4000));
            if (isValid) {
               result = RomanLetterConverter (input);
               Write ($"The roman letter for the given input {input} is ");
               ForegroundColor = ConsoleColor.Green;
               Write (result);
               ResetColor ();
            } else WriteLine ("Invalid input, please enter a valid number.");
         } while (!isValid);
      }
   }
}