using System;

Console.WriteLine("Welcome To our program even or odd :");
bool exit = false;
do {
    Console.WriteLine("Enter a number :");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0) {
        Console.WriteLine("The number is even");
    } else {
        Console.WriteLine("The number is odd");
    }
    Console.WriteLine("Do you want to exit ? Type \"exit\" To countinue Press Anything :");
    string UserInput =  Console.ReadLine().ToLower();
    if (UserInput == "exit") { 
        exit = true;
    }
    else {
        exit = false;
    }
} while (exit == false);