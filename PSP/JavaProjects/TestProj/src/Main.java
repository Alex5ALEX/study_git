import java.util.Scanner;




public class Main {

    public static void main(String[] args) {
      System.out.printf("Hello and welcome!");

      Scanner in  = new Scanner(System.in);

      int num = in.nextInt();

      System.out.println(num);

        for (int i = 1; i <= 5; i++) {
            System.out.println("i = " + i);
        }
    }
}