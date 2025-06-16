<<<<<<< HEAD
﻿using System;
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
=======
﻿// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Simple Calculator ===");

//         Console.Write("Enter your First Number: ");
//         string input1 = Console.ReadLine();
//         double num1 = Convert.ToDouble(input1);

//         Console.WriteLine("You Entered: " + num1);
//     }
// }
// //


// using System;

// class Calculator {

//     static void Main()
//     {
//         Console.Write("Enter your First Number :");
//         Double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Choose your Operator (+,-,*,/):");
//         string op = Console.ReadLine();

//         Console.Write("Enter your Second Number:-");
//         Double num2 = Convert.ToDouble(Console.ReadLine());

//         Double Result = 0;

//         if (op == "+")
//             Result = num1 + num2;
//         else if (op == "-")
//             Result = num1 - num2;
//         else if (op == "*")
//             Result = num1 * num2;
//         else if (op == "/")
//             Result = num1 / num2;
//         Console.WriteLine("Result:" + Result);
//     }

// }
>>>>>>> 61c549233fa23e95d9d779b1f1284ab57da3a669
