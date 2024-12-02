using System;

class Program 
{
  static void Main()
  {
    //display title
    Console.WriteLine("************************************");
    Console.WriteLine("* The Stars Shine in Greenville. *");
    Console.WriteLine("************************************");

    //display menu
    Console.WriteLine("\nPlease Enter the following number below from the following menu: \n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");

    //User choice
    string choicmenu = Console.ReadLine();

    //switch case for different user choices
    switch (choicmenu)
    {
    case "1":
      //input for last years contestants
      int lastYearContestants = GetContestantInput("last year");

      //input for current years contestants
      int currentYearContestants = GetContestantInput("current year");

      //calcuate revenue for current year
      int currentYearRevenue = currentYearContestants * 25;

      //output results
      Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
      Console.WriteLine($"\nRevenue expected this year is ${currentYearRevenue}");

      //check if competition if bigger than last year
      if (currentYearContestants > 2 * lastYearContestants)
      {
        Console.WriteLine("The competition is more than twice as big this year!");
      }
        else if (currentYearContestants > lastYearContestants)
      {
        Console.WriteLine("The competition is bigger than ever!");
      }
      else
      {
        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
      }
      break;

    case "2":
      Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
      break;

    default:
        Console.WriteLine("\nInvalid choice, please try again.");
        break;






    }



  }

  static int GetContestantInput(string year)
    {
        int contestants = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine($"Please enter the number of contestants from {year}  (between 0 and 30):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out contestants) && contestants >= 0 && contestants <= 30)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        }
        return contestants;
    }
}
