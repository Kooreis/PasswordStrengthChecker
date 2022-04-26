```CSharp
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        int score = GetPasswordStrength(password);

        Console.WriteLine("Password strength: " + score);
    }

    static int GetPasswordStrength(string password)
    {
        if (password.Length < 8)
            return 0;

        int score = 1;

        if (HasMixedCase(password))
            score++;
        if (HasDigit(password))
            score++;
        if (HasSpecialChar(password))
            score++;

        return score;
    }

    static bool HasMixedCase(string password)
    {
        bool hasUpper = false, hasLower = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUpper = true;
            else if (char.IsLower(c))
                hasLower = true;
        }

        return hasUpper && hasLower;
    }

    static bool HasDigit(string password)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c))
                return true;
        }

        return false;
    }

    static bool HasSpecialChar(string password)
    {
        string specialChars = "!@#$%^&*()_-+=[{]};:>|./?";

        foreach (char c in password)
        {
            if (specialChars.Contains(c))
                return true;
        }

        return false;
    }
}
```