// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08.//This code is used to check the validity of a password based on certain criteria.
// ------------------------------------------------------------------------------------------------
namespace Training25;

class Password {
   /// <summary>Checks whether the input is empty or null</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & error message</returns>
   public virtual bool Check (string input) {
      if (string.IsNullOrEmpty (input)) {
         Console.WriteLine ("Password cannot be empty");
         return false;
      }
      return true;
   }
}

class PasswordLength : Password {
   /// <summary>Checks whether atleast six character is present or not</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & error message</returns>
   public override bool Check (string input) {
      base.Check (input);
      if (input.Length < 6) {
         Console.WriteLine ("Password length should be at least 6 characters");
         return false;
      }
      return true;
   }
}

class PasswordDigit : PasswordLength {
   /// <summary>Checks whether atleast one digit character is present or not</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & error message</returns>
   public override bool Check (string input) {
      base.Check (input);
      if (!input.Any (char.IsDigit)) {
         Console.WriteLine ("Password should contain at least one digit");
         return false;
      }
      return true;
   }
}

class PasswordUpper : PasswordDigit {
   /// <summary>Checks whether atleast one upper case character is present or not</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & error message</returns>
   public override bool Check (string input) {
      base.Check (input);
      if (!input.Any (char.IsUpper)) {
         Console.WriteLine ("Password should contain at least one uppercase letter");
         return false;
      }
      return true;
   }
}

class PasswordLower : PasswordUpper {
   /// <summary>Checks whether atleast one lower case character is present or not</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & error message</returns>
   public override bool Check (string input) {
      base.Check (input);
      if (!input.Any (char.IsLower)) {
         Console.WriteLine ("Password should contain at least one Lowercase letter");
         return false;
      }
      return true;
   }
}

class PasswordSpecial : PasswordLower {
   /// <summary>Checks whether atleast one special character is present or not</summary>
   /// <param name="input">Gets input from the user as string</param>
   /// <returns>True or False & message about success or error </returns>
   public override bool Check (string input) {
      base.Check (input);
      char[] chars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+', '^' };
      if (input.IndexOfAny (chars) == -1) {
         Console.WriteLine ("Password should contain at least one special character");
         return false;
      } else Console.WriteLine ("Password is Strong");
      return true;
   }
}

internal class Program {
   static void Main (string[] args) {
      bool valid;
      do {
         Console.WriteLine ("Enter the password");
         string password = Console.ReadLine ();
         PasswordSpecial check = new PasswordSpecial ();
         valid = check.Check (password);
         Console.WriteLine ("-----------------");
         if (!valid) Console.WriteLine ("*Please enter a valid password!");
      }
      while (!valid);
   }
}
