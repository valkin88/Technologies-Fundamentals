import java.util.Arrays;
import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char[] arrayOfLetters = scan.nextLine().toLowerCase().toCharArray();

        for (char letter: arrayOfLetters) {
            int numericValueOfLetter = Character.getNumericValue(letter) - 10;
            System.out.printf("%s -> %d%n", letter, numericValueOfLetter);
        }
    }
}
