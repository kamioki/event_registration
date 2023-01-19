using System;
using static System.Console;

// This Assignment requires you to write an application program for a Sporting Event that manages both participants and audiences by performing the following tasks. 
// Task 1: Prompt the user for the number of adult tickets, number of children tickets and number of senior tickets that have been sold during the Event. These numbers should be non-negative.
// Task 2: Display number of tickets of each type and calculate and display the revenue from selling tickets for the event if each adult ticket costs $20.00, each child ticket costs 50% of the adult ticket and a senior ticket costs 75% of the adult ticket. The output must be in currency format.
// Task 3: Display a statement that shows a statistic of visitors attending
// •	if the number of adult tickets is smaller than or equal to the total of children's and senior tickets, the program should display “The event is becoming a festival for everyone!”.
// •	if the number of children's tickets is greater than or equal to senior tickets, the program should display “The event is attracting more and more young people!”.
// •	in other cases, the program should display “The event should have more space for kids!”.
// Task 4: The program prompts the user for the number of participants in this year’s event; the value entered must be between 0 and 40 (inclusive). The program continues to prompt the user until a valid value is entered. 
// Task 5: After the user enters the number of participants, the program prompts the user for the names and event codes for each participant that indicates type of event, S for Swimming, B for Badminton, F for football. Along with the prompt for an event code, display a list of valid categories. Whenever a code is invalid, re-prompt the user for a valid code continuously. Display the count of the number of participants for each event. 


namespace AssessmentB
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare initial value for number of tickets
            int adults = 0, kids = 0, senior = 0;

            /////////////TASK1/////////////
            WriteLine("StudentName: Masayoshi Kamioki (n10838601)\n");
            WriteLine("-----------------TASK1-----------------\n");
            Write("Please enter number of adults:   ");
            //Criterion1-1: ask user to enter number of tickets
            adults = Convert.ToInt32(ReadLine());
            //Criterion1-2: check for the valid value and allow user to enter the correct value
            while (adults < 0)
            {
                Write("Please enter non-negative number for adults: ");
                adults = Convert.ToInt32(ReadLine());
            }
            Write("Please enter number of children: ");
            kids = Convert.ToInt32(ReadLine());
            while (kids < 0)
            {
                Write("Please enter non-negative number for children: ");
                kids = Convert.ToInt32(ReadLine());
            }
            Write("Please enter number of senior:   ");
            senior = Convert.ToInt32(ReadLine());
            while (senior < 0)
            {
                Write("Please enter non-negative number for senior: ");
                senior = Convert.ToInt32(ReadLine());
            }


            ////////////////TASK2/////////////
            WriteLine("\n-----------------TASK2-----------------\n");
            //Criterion2-1: display number of each type of tickets
            WriteLine("Number of tickets: {0} for adult(s), {1} for kid(s), {2} for senior", adults, kids, senior);
            //Criterion2-2: calculate and display the revenue
            double adultfee = 20.00, kidsfee = adultfee * 0.5, seniorfee = adultfee * 0.75;
            double revenue = (adultfee * adults) + (kids * kidsfee) + (senior * seniorfee);
            WriteLine("\nRevenue from selling ticket is ${0:0.00}", revenue);


            ////////////////TASK3/////////////
            WriteLine("\n-----------------TASK3-----------------\n");
            //Calculate3: display statements that show a sttistic of attending visitors
            if (adults <= kids + senior && adults !=0 && senior !=0)
            {
                WriteLine("The event is becoming a festival for everyone!");
            }
            else if (kids >= senior && kids != 0)
            {
                WriteLine("The event is attracting more and more young people!");
            }
            else 
            {
                WriteLine("The event should have more space for kids!");
            }


            //////////////TASK4/////////////
            WriteLine("\n-----------------TASK4-----------------\n");
            int participants = 0;
            Write("Enter number of participants: ");
            //Criterion4-1: input the number of participants
            participants = Convert.ToInt32(ReadLine());
            //Criterion4-2: check and allow user to re-enter if value is not in the range
            while (0 > participants || participants > 40) 
            {
                Write("Please enter between 0-40: ");
                participants = Convert.ToInt32(ReadLine());
            }


            /////////////TASK5/////////////
            WriteLine("\n-----------------TASK5-----------------\n");
            string name, ecode, swimcode = "S", badcode = "B", footcode = "F";
            int num_swim = 0, num_bad = 0, num_foot = 0;
            Write("Select a participating event for each person\n");
            for (int i = 0; i < participants; i++)
            {
                //Criterion5-1: prompt and allow user to enter participant names and events 
                Write("\nEnter participant name: ");
                name = ReadLine();
                //Criterion5-2: display list of valid event codes before inputting it
                WriteLine("\n  <<Event codes>> \n  S for swimming \n  B for badminton \n  F for football");

                Write("\nEnter event code for {0}: ", name);
                ecode = ReadLine();
                //Criterion5-3: check invalid code and allow user to re-enter the valid code
                while (ecode != swimcode && ecode != badcode && ecode != footcode)
                {
                    Write("Please enter valid code S or B or F: ");
                    ecode = ReadLine();
                }
                //count up the number of participants
                if (ecode == swimcode)
                {
                    num_swim++;
                }
                if (ecode == badcode)
                {
                    num_bad++;
                }
                if (ecode == footcode)
                {
                    num_foot++;
                }
            }
            //Criterion5-4: display the count of each event 
            WriteLine("\nNumber of participants for each event:\n" +
                " {0} person(s) for Swimming \n {1} person(s) for Badminton \n {2} person(s) for Football", num_swim, num_bad, num_foot);

            WriteLine("\n********  Enjoy the Sporting Event!  ********");
            
            ReadKey();
        }
    }
}
