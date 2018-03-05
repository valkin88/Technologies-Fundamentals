import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arrayOfIntegers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Boolean result = false;

        if (arrayOfIntegers.length == 1){
            System.out.println("0");
        }
        else{
            int sumOfLeftSide = 0;
            int sumOfRightSide = 0;

            for (int i = 0; i < arrayOfIntegers.length; i++) {
                for (int leftIndex = 0; leftIndex < i; leftIndex++) {
                    sumOfLeftSide +=arrayOfIntegers[leftIndex];
                }
                for (int rightIndex = i + 1; rightIndex < arrayOfIntegers.length; rightIndex++) {
                    sumOfRightSide += arrayOfIntegers[rightIndex];
                }
                if (sumOfLeftSide == sumOfRightSide){
                    System.out.println(i);
                    result = true;
                }
                else{
                    sumOfLeftSide = 0;
                    sumOfRightSide = 0;
                }
            }
            if (result.equals(false)){
                System.out.println("no");
            }
        }
    }
}
