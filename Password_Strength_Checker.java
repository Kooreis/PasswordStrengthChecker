import java.util.Scanner;

public class PasswordStrengthChecker {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter your password:");
        String password = scanner.nextLine();
        if (isValidPassword(password)) {
            System.out.println("Password is strong.");
        } else {
            System.out.println("Password is weak.");
        }
    }
}