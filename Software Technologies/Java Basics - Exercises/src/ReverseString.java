import java.util.ArrayList;
import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        char[] charArray = scan.nextLine().toLowerCase().toCharArray();
        ArrayList<Character> charList = new ArrayList<>();

        for (int i = charArray.length - 1; i >= 0; i--) {
            charList.add(charArray[i]);
        }
        String reversedWord = "";
        for (Character letter: charList) {
            reversedWord += letter;
        }
        System.out.println(reversedWord);
    }
}
