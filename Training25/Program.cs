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
         WriteLine ("Enter the password: ");
         string pass = ReadLine () ?? "";
         if (string.IsNullOrWhiteSpace (pass) || pass.Any (char.IsWhiteSpace)) {
            WriteLine ("Password should not be empty. And no space should be left. Please try again!\n");
            continue;
         }
         var validationResult = PasswordValidator.Validate (pass);
         if (validationResult.Count == 0) {
            WriteLine ("Strong Password.");
            break;
         }
         WriteLine ("Weak Password.");
         validationResult.ForEach (WriteLine);
         WriteLine ("Please try again!\n");
      }
   }
   #endregion
}
#endregion

#region class PasswordValidator -----------------------------------------------------------------------------
static class PasswordValidator {
   /// <summary>Validates the password against multiple conditions</summary>
   /// <param name="text">The password to validate</param>
   /// <returns>Reasons for weak password</returns>
   #region Method -------------------------------------------
   public static List<string> Validate (string text) {
      List<string> condition = [];
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
   #endregion
}
#endregion