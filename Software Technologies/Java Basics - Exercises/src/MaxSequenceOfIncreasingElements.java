import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arrayOfIntegers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int maxCounter = 0;
        String stringOfNumbersInSubsequence = "";
        String saveOfSubsequence = "";

        for (int i = 0; i < arrayOfIntegers.length; i++) {
            int counter = 0;
            stringOfNumbersInSubsequence += arrayOfIntegers[i];

            int index = i;
            for (int j = i + 1; j < arrayOfIntegers.length; j++) {

                if (arrayOfIntegers[index] < arrayOfIntegers[j]){
                    counter++;
                    stringOfNumbersInSubsequence += " " + arrayOfIntegers[j];
                }
                else{
                    break;
                }
                index++;
                
            }
            if (counter > maxCounter){
                maxCounter = counter;
                saveOfSubsequence = stringOfNumbersInSubsequence;
            }
            stringOfNumbersInSubsequence = " ";
            
        }
        System.out.println(saveOfSubsequence);
    }
}
