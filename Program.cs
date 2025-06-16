using System;
using System.Runtime.ConstrainedExecution;

class Login

{
    static void Main()
    {
        Console.WriteLine("===Simple Creditionals===");

        //Assign creditionacial
        string correct_username = "Admin123";
        string correct_password = "Admin@123";

        //Taking user_input 

        Console.Write("Enter your User name :");
        string user_username = Console.ReadLine();

        Console.Write("Enter your password :");
        string user_password = Console.ReadLine();

        //Autorization woth if else statement

        if (correct_username == user_username && correct_password == user_password)
        {
            Console.WriteLine("Login Succesfull");
        }
        else
        {
            Console.WriteLine("Wrong usernam II password");

        }

    }
}