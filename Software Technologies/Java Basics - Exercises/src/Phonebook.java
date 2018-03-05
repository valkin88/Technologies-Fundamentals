import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.concurrent.ConcurrentHashMap;

public class Phonebook {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        Map<String, String> phonebook = new HashMap<>();

        String input = scanner.nextLine();

        while (true){
            if (input.equals("END")){
                break;
            }
            String[] listOfAddedNameAndNumber = input.split(" ");
            String command = listOfAddedNameAndNumber[0];
            String nameOfInput = listOfAddedNameAndNumber[1];

            switch (command){

                case "A":
                    String numberOfInput = listOfAddedNameAndNumber[2];
                    phonebook.put(nameOfInput, numberOfInput);
                    break;
                case "S":
                    if (phonebook.containsKey(nameOfInput)){
                        for (String item: phonebook.keySet()) {
                            item = nameOfInput;
                            System.out.println(item + " -> " + phonebook.get(item));
                            break;
                        }
                    }else{
                        System.out.println("Contact " + nameOfInput + " does not exist.");
                    }
                    break;
            }
            input = scanner.nextLine();
        }
    }
}
