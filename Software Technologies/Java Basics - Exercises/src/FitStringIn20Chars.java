import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        char[] charArray = scan.nextLine().toCharArray();

        StringBuilder buildedStringOfTwentyChars = new StringBuilder();
            for (int i = 0; i <= charArray.length - 1; i++) {
                if (i == 20){
                    break;
                }
                buildedStringOfTwentyChars.append(charArray[i]);
            }
        if (buildedStringOfTwentyChars.length() < 20){
            for (int j = buildedStringOfTwentyChars.length(); j < 20; j++) {
                buildedStringOfTwentyChars.append('*');
            }
        }


        System.out.println(buildedStringOfTwentyChars);

    }
}
