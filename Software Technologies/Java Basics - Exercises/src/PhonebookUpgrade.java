import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        TreeMap<String, String> sortedPhonebook = new TreeMap<>();
        String input = scanner.nextLine();

        while (true) {
            if (input.equals("END")) {
                break;
            }
            String[] listOfAddedNameAndNumber = input.split(" ");
            String command = listOfAddedNameAndNumber[0];
            if (command.equals("ListAll")){
                for (String item : sortedPhonebook.keySet()) {
                    System.out.println(item + " -> " + sortedPhonebook.get(item));
                }
            }else{
                String nameOfInput = listOfAddedNameAndNumber[1];

                switch (command) {
                    case "A":
                        String numberOfInput = listOfAddedNameAndNumber[2];

                        if (!sortedPhonebook.containsKey(nameOfInput)){
                            sortedPhonebook.put(nameOfInput, numberOfInput);
                        }else{
                            sortedPhonebook.replace(nameOfInput, numberOfInput);
                        }

                        break;
                    case "S":
                        if (sortedPhonebook.containsKey(nameOfInput)){
                            for (String item: sortedPhonebook.keySet()) {
                                item = nameOfInput;
                                System.out.println(item + " -> " + sortedPhonebook.get(item));
                                break;
                            }
                        }else{
                            System.out.println("Contact " + nameOfInput + " does not exist.");
                        }
                        break;
                        default:
                            break;
                }
            }

            input = scanner.nextLine();
        }
    }
}
