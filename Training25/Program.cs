// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08.//This code is used to check the validity of a password based on certain criteria.
// ------------------------------------------------------------------------------------------------
namespace Training25;

class Password {
   public virtual bool check (string input) {
      if (string.IsNullOrEmpty (input)) {
         Console.WriteLine ("Password cannot be empty");
         return false;
      }
      return true;
   }
}

class PasswordLength : Password {
   public override bool check (string input) {
      base.check (input);
      if (input.Length < 6) {
         Console.WriteLine ("Password length should be at least 6 characters");
         return false;
      }
      return true;
   }
}

class PasswordDigit : PasswordLength {
   public override bool check (string input) {
      base.check (input);
      if (!input.Any (char.IsDigit)) {
         Console.WriteLine ("Password should contain at least one digit");
         return false;
      }
      return true;
   }
}

class PasswordUpper : PasswordDigit {
   public override bool check (string input) {
      base.check (input);
      if (!input.Any (char.IsUpper)) {
         Console.WriteLine ("Password should contain at least one uppercase letter");
         return false;
      }
      return true;
   }
}

class PasswordLower : PasswordUpper {
   public override bool check (string input) {
      base.check (input);
      if (!input.Any (char.IsLower)) {
         Console.WriteLine ("Password should contain at least one Lowercase letter");
         return false;
      }
      return true;
   }
}

class PasswordSpecial : PasswordLower {
   public override bool check (string input) {
      base.check (input);
      char[] chars = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '+','^' };
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
         string pass = Console.ReadLine ();
         PasswordSpecial check = new PasswordSpecial ();
         valid = check.check (pass);
         Console.WriteLine ("-----------------");
         if (!valid) Console.WriteLine ("*Please enter a valid password!");
         }
      while (!valid);
   }
}
