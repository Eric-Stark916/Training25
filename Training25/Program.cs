// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08.//This code is used to check the validity of a password based on certain criteria.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

static class Password {
   /// <summary>Check the password based on certain conditions</summary>
   /// <param name="input">Gets string input from the user</param>
   /// <returns>number of condition satisfied</returns>
   public static int CountConditions (string input) {
      char[] chars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
      int count = 0;
      WriteLine ("...............");
      if (string.IsNullOrEmpty (input)) WriteLine ("*Password cannot be empty");
      else count++;
      if (input.Length < 6) WriteLine ("*Password length should be at least 6 characters");
      else count++;
      if (!input.Any (char.IsDigit)) WriteLine ("*Password should contain at least one digit");
      else count++;
      if (!input.Any (char.IsUpper)) WriteLine ("*Password should contain at least one " +
                                                                          "uppercase letter");
      else count++;
      if (!input.Any (char.IsLower)) WriteLine ("*Password should contain at least one " +
                                                                          "Lowercase letter");
      else count++;
      if (input.IndexOfAny (chars) == -1) WriteLine ("*Password should contain at least one " +
                                                                         "special character");
      else count++;
      WriteLine ("...............");
      if (count < 6) WriteLine ("Try Again");
      WriteLine ("...............");
      return count;
   }

   /// <summary>Check the password Strength based on the count of conditions satisfied</summary>
   /// <param name="count">Gets count as integer from another method, 
   ///  which checks the number of conditions satisfied </param>
   /// <returns>Password strength</returns>
   public static bool PasswordStrength (int count) {
      bool result = false;
      if (count <= 2) {
         ForegroundColor = ConsoleColor.Red;
         WriteLine ("Very Weak Password");
         ResetColor ();
      } else if (count == 3 || count == 4) {
         ForegroundColor = ConsoleColor.DarkYellow;
         WriteLine ("Weak Password");
         ResetColor ();
      } else if (count == 5) {
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine ("Strong Password");
         ResetColor ();
      } else {
         Clear ();
         ForegroundColor = ConsoleColor.Green;
         WriteLine ("Very Strong Password");
         ResetColor ();
         WriteLine ("Your Password is Valid");
         result = true;
      }
      return result;
   }
}

internal class Program {
   static void Main () {
      bool valid = false;
      while (!valid) {
         WriteLine ("Enter the password");
         string password = ReadLine () ?? "";
         if (Password.PasswordStrength (Password.CountConditions (password))) valid = true;
         else {
            Thread.Sleep (2500);
            Clear ();
         }
      }
   }
}