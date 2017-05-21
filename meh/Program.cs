using System;

namespace meh
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEH System Version 0.3");
            Console.WriteLine("Loading Core System");
            Console.WriteLine("Declaring Startup Variables");
            String command, user, pass, str1, str2, secure, users = null;
            Boolean secure_mode = true;
            Console.WriteLine("Startup Variables Declared");
            Console.Write("Enter Secure Mode? ");
            secure = Console.ReadLine();
            if (string.Equals(secure, "yes") || (string.Equals(secure, "y") || (string.Equals(secure, "true")
        )))
            {
                secure_mode = true;

            }
            else if (string.Equals(secure, "no") || (string.Equals(secure, "n") || (string.Equals(secure, "false")
            )))
            {
                secure_mode = false;

            }
            else { Console.WriteLine("Invalid"); Console.ReadKey(); }
            if (secure_mode == true)


            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                user = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                pass = Console.ReadLine();
                if (string.Equals(user, "admin") & string.Equals(pass, "admin"))
                {
                    Console.WriteLine("Confirming credentials, please wait");
                    Console.WriteLine("Credentials confirmed, hello, " + user);

                    Console.WriteLine("I am The MEH Assistant");
                    while (true)
                    {
                        Console.WriteLine("How may I Help you?");
                        command = Console.ReadLine();
                        if (string.Equals(command, "help"))
                        {
                            Console.WriteLine("Commands: add. For High Level Commands use: Secure(command)");
                        }

                        else if (string.Equals(command, "add"))
                        {
                            Console.Write("What to add?");
                            string input1 = Console.ReadLine();
                            int add1, add2, ans;
                            Int32.TryParse(input1, out add1);
                            Console.Write("And what?");
                            string input2 = Console.ReadLine();
                            Int32.TryParse(input2, out add2);
                            ans = add1 + add2;
                            Console.WriteLine("The answer is " + ans);
                        }
                        else if (string.Equals(command, "subtract"))
                        {
                            Console.Write("What to subtract?");
                            string input1 = Console.ReadLine();
                            int sub1, sub2, ans;
                            Int32.TryParse(input1, out sub1);
                            Console.Write("And what?");
                            string input2 = Console.ReadLine();
                            Int32.TryParse(input2, out sub2);
                            ans = sub1 - sub2;
                            Console.WriteLine("The answer is " + ans);
                        }
                        else if (string.Equals(command, "multiply"))
                        {
                            Console.Write("What to multiply?");
                            string input1 = Console.ReadLine();
                            int mul1, mul2, ans;
                            Int32.TryParse(input1, out mul1);
                            Console.Write("And what?");
                            string input2 = Console.ReadLine();
                            Int32.TryParse(input2, out mul2);
                            ans = mul1 * mul2;
                            Console.WriteLine("The answer is " + ans);
                        }
                        else if (string.Equals(command, "divide"))
                        {
                            Console.Write("What to divide?");
                            string input1 = Console.ReadLine();
                            int div1, div2, ans;
                            Int32.TryParse(input1, out div1);
                            Console.Write("And what?");
                            string input2 = Console.ReadLine();
                            Int32.TryParse(input2, out div2);
                            ans = div1 + div2;
                            Console.WriteLine("The answer is " + ans);
                        }
                        else if (string.Equals(command, "secure(add user)"))
                        {
                            Console.WriteLine("Not supported right now");
                        }
                        else if (string.Equals(command, "exit"))
                        {
                            Console.WriteLine("Exiting");
                            command = null; user = null; pass = null; str1 = null; str2 = null; secure = null; users = null;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("What?");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Credentials Incorrect");
                    Console.ReadKey();


                }
            }
            else if (secure_mode == false)


            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                user = Console.ReadLine();


                {
                    Console.WriteLine("Confirming credentials, please wait");
                    Console.WriteLine("Credentials confirmed, hello, " + user);

                    Console.WriteLine("I am The MEH Assistant");
                    while (true)
                    {
                        Console.WriteLine("How may I Help you?");
                        command = Console.ReadLine();
                        if (string.Equals(command, "help"))
                        {
                            Console.WriteLine("Commands: add. For High Level Commands use: Secure(command)");
                        }

                        else if (string.Equals(command, "add"))
                        {
                            Console.Write("What to add?");
                            string input1 = Console.ReadLine();
                            int add1, add2;
                            Int32.TryParse(input1, out add1);
                            Console.Write("And what?");
                            string input2 = Console.ReadLine();
                            Int32.TryParse(input2, out add2);
                            int ans = add1 + add2;
                            Console.WriteLine("The answer is " + ans);
                        }
                        else if (string.Equals(command, "secure(add user)"))
                        {
                            Console.WriteLine("Error, system cannot process your request without confirming credentials. To confirm credentials, restart MEH system in secure mode");
                        }
                        else if (string.Equals(command, "exit"))
                        {
                            Console.WriteLine("Exiting");
                            command = null; user = null; pass = null; str1 = null; str2 = null; secure = null; users = null;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("What?");
                        }
                    }

                }




            }
            }
        }
    }

