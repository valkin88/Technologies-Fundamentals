import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        if (scan.nextLine().contains("True")){
            System.out.println("Yes");
        }
        else {
            System.out.println("No");
        }
    }
}
