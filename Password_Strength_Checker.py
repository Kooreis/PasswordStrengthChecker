import re

def password_strength(password):
    if len(password) < 8:
        return "Password is too short, must be at least 8 characters"
    elif re.search('[0-9]',password) is None:
        return "Password must contain at least one number"
    elif re.search('[A-Z]',password) is None: 
        return "Password must contain at least one uppercase letter"
    elif re.search('[a-z]',password) is None:
        return "Password must contain at least one lowercase letter"
    elif re.search('[!@#$%^&*(),.?":{}|<>]',password) is None:
        return "Password must contain at least one special character"
    else:
        return "Password is strong"

def main():
    password = input("Enter a password: ")
    print(password_strength(password))

if __name__ == "__main__":
    main()