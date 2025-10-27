// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T08: Strong Password Validator.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter the password: ");
         string? pass = ReadLine ();
         if (string.IsNullOrEmpty (pass)) {
            WriteLine ("Password should not be empty. Please try again!\n");
            continue;
         }
         var result = PasswordValidator.Validate (pass);
         if (result.Count == 0) {
            WriteLine ("Strong Password.");
            break;
         }
         if (pass?.ToLower ().Trim () == "r") {
            WriteLine ("Special Characters are: ! @ # $ % & * ( ) - + ^\n");
            continue;
         }
         WriteLine ("Weak Password.");
         result.ForEach (WriteLine);
         WriteLine ("Please try again!\n");
      }
   }
   #endregion
}
#endregion

#region class PasswordValidator -------------------------------------------------------------------
public static class PasswordValidator {
   #region Method ---------------------------------------------------
   /// <summary>Validates the password against multiple conditions</summary>
   /// <param name="text">The password to validate</param>
   /// <returns>Reasons for weak password</returns>
   public static List<string> Validate (string text) {
      List<string> condition = [];
      if (text.Any (char.IsWhiteSpace))
         condition.Add ("*Password should not contain space.");
      if (text.Length < 6)
         condition.Add ("*Password length should be at least 6 characters.");
      if (!text.Any (char.IsDigit))
         condition.Add ("*Password should contain at least one digit.");
      if (!text.Any (char.IsUpper))
         condition.Add ("*Password should contain at least one uppercase letter.");
      if (!text.Any (char.IsLower))
         condition.Add ("*Password should contain at least one lowercase letter.");
      if (text.IndexOfAny (sSplchars) == -1)
         condition.Add ("*Password should contain at least one special character. Press 'R' to reveal the characters.");
      return condition;
   }
   static readonly char[] sSplchars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
   #endregion
}
#endregion