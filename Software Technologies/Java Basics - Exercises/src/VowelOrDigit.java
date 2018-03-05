import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        List<String> chars = Arrays.asList("a", "e", "u", "o", "i", "y");
        List<String> numbers = Arrays.asList("0", "1", "2", "3", "4", "5", "6", "7", "8", "9");

        String input = scan.nextLine();

        if (chars.contains(input)){
            System.out.println("vowel");
        }
        else if (numbers.contains(input)){
            System.out.println("digit");
        }
        else{
            System.out.println("other");
        }
    }
}
