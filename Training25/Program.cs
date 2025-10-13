// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T08: Strong Password Validator
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

static class Password {
   /// <summary>Validates the password against multiple conditions</summary>
   /// <param name="input">The password to validate</param>
   /// <returns>The number of conditions satisfied by the password</returns>
   public static int ConditionsSatisfied (string input) {
      char[] chars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
      int count = 0;
      WriteLine ("...............");
      if (input.Length < 6) WriteLine ("*Password length should be at least 6 characters");
      else count++;
      if (!input.Any (char.IsDigit)) WriteLine ("*Password should contain at least one digit");
      else count++;
      if (!input.Any (char.IsUpper)) WriteLine ("*Password should contain at least one " +
                                                                          "uppercase letter");
      else count++;
      if (!input.Any (char.IsLower)) WriteLine ("*Password should contain at least one " +
                                                                          "lowercase letter");
      else count++;
      if (input.IndexOfAny (chars) == -1) WriteLine ("*Password should contain at least one " +
                                                                         "special character");
      else count++;
      return count;
   }

   /// <summary>Evaluates the password strength based on the number of conditions satisfied</summary>
   /// <param name="count">The number of conditions satisfied by the password</param>
   /// <returns>True if password is valid</returns>
   public static bool IsPasswordValid (int count) {
      bool result = false;
      if (count <= 4) {
         ForegroundColor = ConsoleColor.Red;
         WriteLine ("Weak password\nTry again");
      } else {
         ForegroundColor = ConsoleColor.Green;
         WriteLine ("Strong password\nYour password is valid");
         result = true;
      }
      ResetColor ();
      return result;
   }
}

internal class Program {
   static void Main () {
      bool isValid = false;
      while (!isValid) {
         WriteLine ("Enter the password: ");
         string password = ReadLine () ?? "";
         if (!string.IsNullOrEmpty (password)) {
            isValid = true;
            if (!Password.IsPasswordValid (Password.ConditionsSatisfied (password))) isValid = false;
         } else WriteLine ("Invalid input");
      }
   }
}