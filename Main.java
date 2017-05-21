

package meh;    
import java.util.Objects;
import java.util.Scanner;
public class Main {

public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
        String command, user, pass, str1, str2, users = null;
        Boolean secure_mode;
        System.out.println("MEH System Version 0.2");
        System.out.println("Loading Core System");
        System.out.print("Enter secure mode: ");
secure_mode=sc.nextBoolean();

if (secure_mode==false) {
    System.out.println("Loading...");
    System.out.print("Enter User Name: ");
    user = sc.next();
    System.out.println("Confirmed, hello, " + user);
    System.out.println("I am The Meh Assistant");
    while (true) {
        System.out.println("How may I Help you?");

        command = sc.next();
   /*if (Objects.equals(command,"add user")) {
        System.out.println("Error, system cannot process your request without confirming credentials. To confirm credentials, restart MEH system in secure mode");
    }*/
        if (Objects.equals(command, "help")) {
            System.out.println("Commands");}
            else if (command.equals("add")){System.out.print("What to add?");
            int add1 = sc.nextInt();
            System.out.print("And what?");
            int add2 = sc.nextInt();
            int ans = add1+add2;
            System.out.println("The answer is "+ans);
    } else {
            System.out.println("What?");
        }
    }}
    else if (secure_mode == true) {
        System.out.println("Loading...");
        System.out.print("Enter User Name: ");
        user = sc.next();
        System.out.print("Enter Password: ");
        pass = sc.next();
        if (user.equals("admin") && pass.equals("admin")) {
            System.out.println("Confirming credentials, please wait");
            System.out.println("Credentials confirmed, hello, " + user);

            System.out.println("I am The MEH Assistant");
            while (true) {
                System.out.println("How may I Help you?");
                command = sc.next();
/*else if  (!"add user".equals(command)){
    System.out.println("Not supported right now");
    str1=null;*/
                if (Objects.equals(command, "help")) {
                    System.out.println("Commands: add. For High Level Commands use: Secure(command)");
                } 
                
                else if (command.equals("add")){System.out.print("What to add?");
                int add1 = sc.nextInt();
                System.out.print("And what?");
                int add2 = sc.nextInt();
                int ans = add1+add2;
                System.out.println("The answer is "+ans);}
                else if  (!"secure(add user)".equals(command)){
                System.out.println("Not supported right now");
                str1=null;}
                else {
                    System.out.println("What?");
                }
            }
        
    } else {
        System.out.println("Credentials Incorrect");
    }

}}}