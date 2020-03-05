using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_The_Expert_System
{
    // Application:    The Expert System
    // Author:         Noah Hockin
    // Description     An application that calculates the time smeone has been alive in various 
    //                 units such as seconds, minutes, hours, and so on.
    // Date Created:   2/17/2020
    // Date Revised:   3/2/2020

    class Program
    {
        static void Main(string[] args)
        {
            //screen configurations and theme
            
            ConsoleColor openingClosingScreenBackground = ConsoleColor.White;
            ConsoleColor openingClosingScreenForeground = ConsoleColor.DarkCyan;
            ConsoleColor appScreenBackground = ConsoleColor.White;
            ConsoleColor appScreenForeground = ConsoleColor.DarkCyan;

            //variables
            
            string userName;
            string userResponse;
            int birthYear;
            int currentYear;
            int birthMonth;
            int currentMonth;
            int birthDay;
            int currentDay;
            double yearsAlive;
            double monthsAlive;
            double weeksAlive;
            double daysAlive;
            double hoursAlive;
            double minutesAlive;
            double secondsAlive;
            double yearsApprox;
            double monthsApprox;
            double yearDays;
            double monthDays;
            double dayDays;
            bool validResponse;

            //opening screen
            //set cursor invisible, background colors, foreground colors, and clear screen

            Console.CursorVisible = false;
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();

            //display opening screen

            Console.WriteLine();
            Console.WriteLine("\t\tTime Alive Calculator");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //initial user screen
            //set cursor invisible, background colors, foreground colors, and clear screen

            Console.CursorVisible = true;
            Console.BackgroundColor = appScreenBackground;
            Console.ForegroundColor = appScreenForeground;
            Console.Clear();

            //greet user

            Console.WriteLine();
            Console.WriteLine(" Hello!");
            Console.WriteLine(" This application is designed to calculate how long you have been alive even down o seconds! ");

            //getusers name and echo it back

            Console.WriteLine();
            Console.Write(" What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine(" It is nice to meet you " + userName + ".");

            //determine if user would like to know how long they have been alive more accurately than years

            Console.WriteLine();
            Console.Write($" Are you interested in knowing how long you have been alive in months, weeks, days, hours, minutes, and even seconds {userName}? ");
            userResponse = Console.ReadLine();

            //get more info if response was yes

            if (userResponse == "yes")
            {
                //user information screen
                //set cursor visible and clear screen

                Console.CursorVisible = true;
                Console.Clear();

                //display header

                Console.WriteLine();
                Console.WriteLine("\t\tAge Information");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Well then you are in luck! I shall tell you.");
                Console.WriteLine();
                Console.WriteLine(" I will need to get some more information from you and then I can calculate your age in all those previously mentioned units.");

                //get users birthday and validate response
                //get the year the user was born

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What Year were you born? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out birthYear))
                    {

                        validResponse = false;
                        Console.CursorVisible = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid year. Please be sure to enter the year as a positive number.");

                        //pause app


                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //get the month the user was born

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What month were you born? Please enter the month by its number. ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out birthMonth))
                    {

                        validResponse = false;
                        Console.CursorVisible = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid month. Please be sure to enter the month as a positive number.");

                        //pause app


                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //get the day the user was born

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What day of the month were you born? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out birthDay))
                    {
                        validResponse = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid day. Please be sure to enter the day as a positive number.");

                        //pause app

                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //get the current year

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What year is it currently? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out currentYear))
                    {
                        validResponse = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid year. Please be sure to enter the year as a positive number.");

                        //pause app

                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //get the current month

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What month is it currently? Please enter the month by its number. ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out currentMonth))
                    {
                        validResponse = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid month. Please be sure to enter the month as a positive number.");

                        //pause app

                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //get the current day

                do
                {
                    validResponse = true;

                    //birthdate nformation
                    //set cursor visible and clear screen

                    Console.CursorVisible = true;
                    Console.Clear();

                    //ask question

                    Console.WriteLine();
                    Console.Write("What day of the month is it today? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out currentDay))
                    {
                        validResponse = false;
                        Console.WriteLine();
                        Console.WriteLine("It seems you have entered an invalid day. Please be sure to enter the day as a positive number.");

                        //pause app

                        Console.WriteLine();
                        Console.WriteLine("\tPress any key to continue.");
                        Console.ReadKey();
                    }
                } while (!validResponse);

                //set cursor visible and clear screen

                Console.CursorVisible = true;
                Console.Clear();

                //calculate the users current lifespan

                yearsApprox = ((currentYear - birthYear) - 1);
                monthsApprox = ((currentMonth - 1) + (12 - birthMonth));
                yearDays = yearsApprox * 365;
                monthDays = monthsApprox * 30;
                dayDays = (30 - birthDay) + currentDay;
                yearsAlive = (yearDays + monthDays + dayDays) / 365;
                monthsAlive = yearsAlive * 12;
                weeksAlive = yearsAlive * 52.143;
                daysAlive = yearsAlive * 365.25;
                hoursAlive = yearsAlive * 8766;
                minutesAlive = yearsAlive * 525960;
                secondsAlive = yearsAlive * 31557600;

                //display the numbers for the user

                Console.WriteLine();
                Console.WriteLine("\t\tResults");
                Console.WriteLine();
                Console.WriteLine("The calculations have been made and here are the results!");
                Console.WriteLine();
                Console.WriteLine("You have been alive for approximately " + yearsAlive + " years,");
                Console.WriteLine("\tOR");
                Console.WriteLine(monthsAlive + " months,");
                Console.WriteLine("\tOR");
                Console.WriteLine(weeksAlive + " weeks,");
                Console.WriteLine("\tOR");
                Console.WriteLine(daysAlive + " days,");
                Console.WriteLine("\tOR");
                Console.WriteLine(hoursAlive + " hours,");
                Console.WriteLine("\tOr");
                Console.WriteLine(minutesAlive + " minutes,");
                Console.WriteLine("\tOR");
                Console.WriteLine(secondsAlive + " seconds.");
                Console.WriteLine();

                //pause

                Console.WriteLine();
                Console.WriteLine("\tPress any key to continue.");
                Console.ReadKey();

                //closing screen

                Console.CursorVisible = true;
                Console.Clear();

                //thank the user
                Console.WriteLine();
                Console.WriteLine("\t\tClosing Screen");
                Console.WriteLine();
                Console.WriteLine("Thank you for using this app and I hope you found it helpful and Interesting");

                //pause

                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }
            else
            {
                //
                //      **********************************
                //      *   User Not Interested Screen   *
                //      **********************************
                //
                // set cursor visible and clear screen
                //

                Console.CursorVisible = true;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($" I am sorry you are not interested {userName}");
                Console.WriteLine(" Have a nice day.");

                //
                // display a prompt to exit the application
                //
                Console.WriteLine();
                Console.WriteLine(" Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
