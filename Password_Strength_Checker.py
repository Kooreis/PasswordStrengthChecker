def password_strength(password):
    if len(password) < 8:
        return "Password is too short, must be at least 8 characters"