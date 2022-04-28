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