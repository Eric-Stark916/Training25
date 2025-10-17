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
         Write (Password.PasswordValidator (pass));
         if (Password.PasswordValidator (pass) == "Strong Password.") break;
      }
   }
}

static class Password {
   /// <summary>Validates the password against multiple conditions</summary>
   /// <param name="input">The password to validate</param>
   /// <returns>Strong or weak password and also the conditions to be addressed</returns>
   public static string PasswordValidator (string inp) {
      List<string> condi = [];
      char[] chars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
      if (string.IsNullOrWhiteSpace (inp)) condi.Add ("*Password should not be empty.");
      else {
         if (inp.Any (char.IsWhiteSpace)) condi.Add ("*There should be no space in the whole password.");
         if (inp.Length < 6) condi.Add ("*Password length should be at least 6 characters.");
         if (!inp.Any (char.IsDigit)) condi.Add ("*Password should contain at least one digit.");
         if (!inp.Any (char.IsUpper)) condi.Add ("*Password should contain at least one " +
                                                                             "uppercase letter.");
         if (!inp.Any (char.IsLower)) condi.Add ("*Password should contain at least one " +
                                                                             "lowercase letter.");
         if (inp.IndexOfAny (chars) == -1) condi.Add ("*Password should contain at least one " +
                                                                            "special character.");
      }
      return condi.Count == 0 ? "Strong Password." : "Weak Password.Try again.\nHints:\n" +
                                                     string.Join ("\n", condi) + "\n\n";
   }
}