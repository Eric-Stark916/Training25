// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Training25;
internal class Program {
   public static string numbertowords (int input) {
      string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                             "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen", };


      string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


      string Tens (int input) {
         if (input > 19 && input < 100) {
            int firstdigit = input / 10;
            int seconddigit = input % 10;
            return tens[firstdigit] + " " + ones[seconddigit];
         } else if (input < 20) {
            return ones[input];
         } else {
            return "";
         }
      }
      string[] hundreds = { "", "One Hundred", "Two Hundred", "Three Hundred", "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred", "Eight Hundred", "Nine Hundred" };

      string Hundreds (int input) {
         int firstdigit = input / 100;
         int seconddigit = input % 100;
         return hundreds[firstdigit] + " and " + Tens (seconddigit);
      }

      string[] thousands = { "", "One Thousand", "Two Thousand", "Three Thousand", "Four Thousand", "Five Thousand", "Six Thousand", "Seven Thousand", "Eight Thousand", "Nine Thousand" };

      string Thousands (int input) {
         int firstdigit = input / 1000;
         int seconddigit = input % 1000;
         if (seconddigit == 0) {
            return thousands[firstdigit];
         } else {
            return thousands[firstdigit] + " " + Hundreds (seconddigit);
         }


      }

      if (input == 0) {
         return "Zero";
      } else if (input < 100) {
         return Tens (input);
      } else if (input < 1000) {
         return Hundreds (input);
      } else if (input < 10000) {
         return Thousands (input);
      } else {
         return "Input out of range";
      }

   }






   public static string Romanletterconverter (int input) {

      string[] firstten = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
      string result1 = "";


      string numberupto39 (int input) {
         if (input < 11) {
            return firstten[input];
         } else if (input > 10 && input < 40) {
            int firstdigit = input / 10;
            int seconddigit = input % 10;

            for (int i = 1; i <= firstdigit; i++) {
               result1 += firstten[10];
            }
            return result1 + firstten[seconddigit];
         } else return "";
      }

      string numberupto90 (int input) {
         if (input > 39 && input < 50) {

            int seconddigit = input % 10;
            return "XL" + numberupto39 (seconddigit);
         } else if (input > 49 && input < 90) {

            int seconddigit = input % 50;
            return "L" + numberupto39 (seconddigit);
         } else if (input > 89 && input < 100) {

            int seconddigit = input % 10;
            return "XC" + numberupto39 (seconddigit);
         } else {
            return numberupto39 (input);
         }
      }
      string result2 = "";

      string numberupto400 (int input) {
         if (input > 99 && input < 400) {

            int firstdigit = input / 100;
            int seconddigit = input % 100;

            for (int i = 1; i <= firstdigit; i++) {

               result2 += "C";

            }
            return result2 + numberupto90 (seconddigit);

         } else return numberupto90 (input);
      }

      string upto1000 (int input) {
         if (input > 399 && input < 500) {
            int seconddigit = input % 100;
            return "CD" + numberupto90 (seconddigit);
         } else if (input > 499 && input < 900) {
            int seconddigit = input % 500;
            return "D" + numberupto90 (seconddigit);
         } else if (input > 899 && input < 1000) {
            int seconddigit = input % 100;
            return "CM" + numberupto90 (seconddigit);
         } else {
            return numberupto400 (input);
         }
      }
      string upto4000 (int input) {
         if (input > 999 && input < 4000) {
            int firstdigit = input / 1000;
            int seconddigit = input % 1000;
            string result3 = "";
            for (int i = 1; i <= firstdigit; i++) {
               result3 += "M";
            }
            return result3 + upto1000 (seconddigit);
         } else {
            return upto1000 (input);
         }
      }


      if (input < 40) return numberupto39 (input);
      else if (input > 39 && input < 100) return numberupto90 (input);
      else if (input > 99 && input < 400) return numberupto400 (input);
      else if (input > 399 && input < 1000) return upto1000 (input);
      else if (input > 999 && input < 4000) return upto4000 (input);
      else
         return "Invalid one";

   }



   static void Main (string[] args) {

      int n;
      do {
         Console.WriteLine ("What do you want to convert?\n1.Number to Words\n2.Number to Roman Letters");
          n = int.Parse (Console.ReadLine ());
      }while (n != 1 && n != 2);

     



       string result = "";
         do {
            if (n == 1) {
               Console.WriteLine ("Enter a number between 0 and 9999:");
               int input = int.Parse (Console.ReadLine ());
               result = numbertowords (input);
               Console.WriteLine ($"The Word format for the given input {input} is {result} ");
              
            }
         }
         while (result == "Invalid one");


         do {

            if (n == 2) {
               Console.WriteLine ("Enter a number between 1 to 3999:");
               int input = int.Parse (Console.ReadLine ());
               result = Romanletterconverter (input);
               Console.WriteLine ($"The roman letter for the given input {input} is {result} ");
               

            }

         }
         while (result == "Input out of range" || result == "Invalid one");

      
      



   }
}
      
      
   
