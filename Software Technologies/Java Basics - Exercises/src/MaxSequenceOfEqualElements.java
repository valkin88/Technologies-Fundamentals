import java.util.ArrayList;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] array = scan.nextLine().split(" ");
        Integer[] listOfInts = new Integer[array.length];
        for (int i = 0; i < array.length; i++) {
            listOfInts[i] = Integer.parseInt(array[i]);
        }
        ArrayList<Integer> listEqualElements = new ArrayList<>();

        int maxCounter = 0;
        int numberOfMaxSequal = 0;

        for (int i = 0; i < listOfInts.length; i++) {
            int counter = 0;
            for (int j = i + 1; j < listOfInts.length; j++) {

                if (listOfInts[i].equals(listOfInts[j])){
                    counter++;
                }
                else{
                    break;
                }
            }
            if (counter > maxCounter){
                maxCounter = counter;
                numberOfMaxSequal = listOfInts[i];
            }
        }

        for (int i = 0; i <= maxCounter; i++) {
            listEqualElements.add(numberOfMaxSequal);
        }
        for (Integer digit: listEqualElements) {
            System.out.print(digit + " ");
        }

    }
}
