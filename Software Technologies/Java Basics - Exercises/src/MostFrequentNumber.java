import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arrayOfIntegers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int maxCounter = 0;
        int mostFrequentInt = 0;
        for (int i = 0; i < arrayOfIntegers.length; i++) {
            int counter = 1;
            for (int j = i + 1; j < arrayOfIntegers.length; j++) {
                if (arrayOfIntegers[i] == arrayOfIntegers[j]){
                    counter++;

                }
            }
            if (counter > maxCounter){
                maxCounter = counter;
                mostFrequentInt = arrayOfIntegers[i];
            }

        }
        System.out.println(mostFrequentInt);
    }
}
