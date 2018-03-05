import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class BombNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arrayOfIntegers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] listOfSpecialNumberAndPower = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        ArrayList<Integer> listOfNumbers = new ArrayList<Integer>();

        for (int i = 0; i < arrayOfIntegers.length; i++) {
            listOfNumbers.add((arrayOfIntegers[i]));
        }


        int specialNumber = listOfSpecialNumberAndPower[0];
        int powerOfSpecialNumber = listOfSpecialNumberAndPower[1];

        while (listOfNumbers.indexOf(specialNumber) >= 0){
            Explode(listOfNumbers, specialNumber, powerOfSpecialNumber);
        }
        int sum = listOfNumbers.stream().mapToInt(Integer::intValue).sum();
        System.out.println(sum);

    }

    private static void Explode(ArrayList<Integer> listOfNumbers, int specialNumber, int powerOfSpecialNumber) {
        int bombIndex = listOfNumbers.indexOf(specialNumber);
        int removalIndex = bombIndex - powerOfSpecialNumber;
        int deletionsCount = powerOfSpecialNumber * 2 + 1;

        if (removalIndex < 0) {
            deletionsCount += removalIndex;
            removalIndex = 0;
        }
        while (deletionsCount > 0 && removalIndex < listOfNumbers.size()) {
            listOfNumbers.remove(removalIndex);
            deletionsCount--;
        }
    }

}
