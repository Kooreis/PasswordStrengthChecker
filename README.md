# Python Documentation

# Password Strength Checker

This Python script checks the strength of a password based on certain criteria. It checks if the password is at least 8 characters long, contains at least one number, one uppercase letter, one lowercase letter, and one special character.

## Libraries Used

- `re`: This is Python's built-in module for regular expressions. It is used to perform searches for specific patterns in the password string. In this script, it is used to check if the password contains at least one number, one uppercase letter, one lowercase letter, and one special character.

## How to Use

To use this script, simply run it in your Python environment. You will be prompted to enter a password. After entering a password, the script will check its strength based on the criteria mentioned above and print out a message indicating whether the password is strong or not, and if not, what it is missing.

## Functions

- `password_strength(password)`: This function takes a password as input and checks its strength. It uses regular expressions to check if the password meets the required criteria. If the password does not meet a certain criterion, the function returns a message indicating what the password is missing. If the password meets all the criteria, it returns a message indicating that the password is strong.

- `main()`: This is the main function that runs when the script is executed. It prompts the user to enter a password, then calls the `password_strength` function with the entered password and prints out the returned message.

## Execution

To execute the script, use the following command:

```python
python password_strength_checker.py
```

After running the script, you will be prompted to enter a password. Enter your password and press Enter. The script will then check the strength of your password and print out a message indicating whether your password is strong or not, and if not, what it is missing.

---

# C# Documentation

# Password Strength Checker in C#

This is a simple console application written in C# that checks the strength of a user's password. The strength of the password is determined based on the following criteria:

- Length of the password
- Use of mixed case (upper and lower case) characters
- Inclusion of digits
- Inclusion of special characters

## Code Explanation

The script begins by prompting the user to enter their password. The entered password is then passed to the `GetPasswordStrength` function which calculates and returns the strength of the password.

The strength of the password is initially set to 1 if the length of the password is 8 or more characters. It is then incremented by 1 for each of the following conditions that are met:

- The password contains both upper and lower case characters (`HasMixedCase` function)
- The password contains at least one digit (`HasDigit` function)
- The password contains at least one special character (`HasSpecialChar` function)

The final strength of the password is then displayed to the user.

## Imported Libraries

The script uses the following libraries:

- `System`: This is a built-in .NET library that provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for console input/output and for handling strings and characters.
- `System.Linq`: This is a .NET library that provides classes and interfaces that support queries that use Language-Integrated Query (LINQ). In this script, it is used for the `Contains` method which checks if a string contains a specific character.

## Usage

To use this script, simply run the `Program.cs` file in a .NET environment. When prompted, enter your password to get its strength score. The higher the score, the stronger the password.

---

# Java Documentation

# Password Strength Checker in Java

This Java script is a simple password strength checker. It prompts the user to enter a password and then checks if the password is strong or weak based on certain criteria.

## What the script does

The script uses the `Scanner` class to take user input. It then checks the entered password against a set of rules defined in a regular expression. If the password meets all the rules, it is considered strong; otherwise, it is considered weak.

The rules for a strong password are as follows:

- It must have at least 8 characters.
- It must contain at least one digit.
- It must contain at least one lower case letter.
- It must contain at least one upper case letter.
- It must contain at least one special character from @#$%^&+=.
- It must not contain any whitespace.

## Imported Libraries

The script uses the following libraries:

- `java.util.Scanner`: This class is used to get input from the user. In this script, it is used to read the password entered by the user.

- `java.util.regex.Pattern` and `java.util.regex.Matcher`: These classes are part of Java's regular expression API. A `Pattern` object is a compiled representation of a regular expression. A `Matcher` object is used to match the regular expression against a string. In this script, they are used to check if the entered password matches the regular expression that defines the rules for a strong password.

## How to Run the Script

To run the script, you need to have Java installed on your machine. You can then compile the script using the `javac` command and run it using the `java` command.

```bash
javac PasswordStrengthChecker.java
java PasswordStrengthChecker
```

You will then be prompted to enter a password. After you enter a password, the script will tell you if the password is strong or weak.

---
