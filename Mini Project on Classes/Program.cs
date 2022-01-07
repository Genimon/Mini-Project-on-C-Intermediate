using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_on_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Make your selection of program you want to access.
Enter S to select StopWatch
Enter P to select StackOverflow Post");

                var selection = (string)Console.ReadLine(); // Making selection of the program to access.


                const string timer = "s";
                const string stackpost = "p";

                switch (selection.ToLower())
                {
                    case timer:
                        Console.WriteLine();
                        Console.WriteLine(@"You selected StopWatch Timer.
This program simulate Stopwatch features");
                        Console.WriteLine(@"Make your selection of the Stopwatch that you want based on the numbering.
1 - Start Timer
2 - Stop Timer
3 - Timer Duration");
                        //Console.WriteLine();
                        Console.WriteLine(StopWatch()); // Accessing Facebook Like Program
                        Console.WriteLine();
                        continue;

                    case stackpost:
                        Console.WriteLine();
                        Console.WriteLine(@"You selected Names Reversal
This program reversed the name inputted into the console.");

                        Console.WriteLine(StackOverFlow()); // Accessing Names Reversal Program
                        Console.WriteLine();
                        continue;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You've made an invalid selection");
                        Console.WriteLine();
                        break;
                }
                break;

            }


        }

        public static string StopWatch()
        {

            var stopwatch = new Stopwatch();
            int selection;

            do
            {
                //Console.WriteLine(@"Make your selection of the Stopwatch that you want based on the numbering. \n 1 - Start Timer \n 2 - Stop Timer \n 3 - Timer Duration");
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1: stopwatch.StartTime(); break;

                    case 2: stopwatch.StopTime(); break;

                    case 3: Console.WriteLine(stopwatch.StopwatchDuration()); break;

                }

            } while (selection != 0);

            return "Stopwatch";

        }


        public static string StackOverFlow()
        {
            var genimonPost = new Post();

            genimonPost.Title = "Summary of the C# Tutorial Class on Classes and OOP with Mosh Hamedani";

            genimonPost.Description = @"The lesson had on classes and OOP can be summarised in the following:
Class is a building block of application design. An aplication consists of various classes each responsible for a particular function in the apllication. In a real world example is a situation in which we intend to implement a web application as a blog engine with a typical layered architecture. It will consists of at least three layers; PRESENTATION, BUSINESSS LOGIC / DOMAIN, DATA ACCESS / PERSISTENCE.

PRESENTATION - PostView Class
BUSINESSS LOGIC / DOMAIN - Post Class
DATA ACCESS / PERSISTENCE - PostRepository. 

An Access Modifier is way to control access to a class or its members in order to create safety in our programs. Another reason for access modifiers is to facilitate OOP - Object-oriented Programming
-- Encapsulation/ Information Hiding
-- Inheritance 
-- Polymorphism ";

            genimonPost.PostTime = new DateTime(2021, 11, 11);

            genimonPost.VoteUp();
            genimonPost.VoteUp();
            genimonPost.VoteUp();
            genimonPost.VoteUp();

            Console.WriteLine("Should Have 4 Votes");

            genimonPost.PrintPost();


            genimonPost.VoteDown();
            genimonPost.VoteDown();
            genimonPost.VoteDown();
            
            Console.WriteLine("Should Have 3 Votes");
            genimonPost.PrintPost();

            return "okay";
        
        }
    }
}
