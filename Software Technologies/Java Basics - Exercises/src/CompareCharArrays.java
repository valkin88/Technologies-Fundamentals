import java.util.*;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String firstInput = scan.nextLine();
        String secondInput = scan.nextLine();

        String[] firstArray = firstInput.split("\\s+");
        String[] secondArray = secondInput.split("\\s+");

        String firstString = "";
        String secondString = "";


        for (int i = 0; i < firstArray.length; i++) {
            firstString += firstArray[i];
        }

        for (int i = 0; i < secondArray.length; i++) {
            secondString += secondArray[i];
        }

        List<String> concatenatedStrings = Arrays.asList(firstString, secondString);
        Collections.sort(concatenatedStrings);
        for (String item: concatenatedStrings) {
            System.out.println(item);
        }
    }
}
