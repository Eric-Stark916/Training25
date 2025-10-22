// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T08: Strong Password Validator
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         WriteLine ("Enter the password: ");
         string pass = ReadLine () ?? "";
         if (string.IsNullOrWhiteSpace (pass)) {
            WriteLine ("Password should not be empty.Please try again!\n");
            continue;
         }
         var invalid = PasswordValidator.Validate (pass);
         if (invalid.Count == 0) {
            WriteLine ("Strong Password.");
            break;
         } else {
            WriteLine ("Weak Password.\nReason:");
            invalid.ForEach (WriteLine);
            WriteLine ("Please try again!");
            WriteLine ();
         }
      }
   }
}

static class PasswordValidator {
   /// <summary>Validates the password against multiple conditions</summary>
   /// <param name="text">The password to validate</param>
   /// <returns>Reason for weak password</returns>
   public static List<string> Validate (string text) {
      List<string> condition = [];
      if (text.Any (char.IsWhiteSpace))
         condition.Add ("*There should be no space in the whole password.");
      if (text.Length < 6)
         condition.Add ("*Password length should be at least 6 characters.");
      if (!text.Any (char.IsDigit))
         condition.Add ("*Password should contain at least one digit.");
      if (!text.Any (char.IsUpper))
         condition.Add ("*Password should contain at least one uppercase letter.");
      if (!text.Any (char.IsLower))
         condition.Add ("*Password should contain at least one lowercase letter.");
      if (text.IndexOfAny (sSplchars) == -1)
         condition.Add ("*Password should contain at least one special character.");
      return condition;
   }
   static readonly char[] sSplchars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
}