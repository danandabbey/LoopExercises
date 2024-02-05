﻿using System;

namespace LoopExercises
{
    internal class Program
    {
        public static void Main()
        {
            
        }
        
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        //Display the count on the console.
        
        public static void Exercise1()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        // Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.
        
        public static void Exercise2()
        {
            var total = 0;
            while (true)
            {
                Console.Write("Enter a whole number: ");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }

                var num = Convert.ToInt32(input);
                total += num;
            }

            Console.WriteLine(total);
        }
        
        //Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should calculate
        //5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public static void Exercise3()
        {
            Console.Write("Enter a whole number: ");
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            var result = 1;

            for (var i = num; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine($"{num}! = {result}");
            
            
        }
        
        //Write a program that picks a random number between 1 and 10.
        //Give the user 4 chances to guess the number. If the user guesses the number,
        //display “You won"; otherwise, display “You lost". (To make sure the program is
        //behaving correctly, you can display the secret number on the console first.)

        public static void Exercise4()
        {
            var random = new Random();
            var randomNum = random.Next(1, 10);
            Console.WriteLine("Try to guess a random number between 1 and 10.");
            Console.WriteLine("You have 4 chances.");
            var i = 1;
            
            while (true)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNum)
                {
                    Console.WriteLine($"You won!");
                    break;
                }
                
                if (i == 4)
                {
                    Console.WriteLine($"You Lost, the correct answer is {randomNum}");
                    break;
                }
                Console.WriteLine("Incorrect, try again");
                i++;
            }

        }
        
        //Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console. For example, if the
        //user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void Exercise5()
        {
            Console.Write("Enter a series of whole numbers separated by commas.");
            var input = Console.ReadLine();
            var list = input.Split(',');
            var numList = new int[list.Length];
            var i = 0;
            var largest = 0;
            foreach(var item in list)
            {
                numList[i] = Convert.ToInt32(item);
                i++;
            }

            for (var x = 0; x < numList.Length -1; x++)
            {
                var scopeLargest = largest;
                var l = Math.Max(numList[x], numList[x + 1]);
                largest = Math.Max(l, scopeLargest);
            }

            Console.WriteLine(largest);
        }
    }
}