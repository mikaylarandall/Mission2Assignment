using System.Security.AccessControl;

using Mission2Assignment;

internal class Program
{
    private static void Main()
    {

        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.WriteLine("How many dice would you like to simulate?");
        int numberRolls = int.Parse(System.Console.ReadLine());

        DiceRoller dr = new DiceRoller();
        int[] results = dr.SimulateDice(numberRolls);

        printResults(results, numberRolls);

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }

    static void printResults(int[] results, int totalRolls)
    {
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each * represents 1% of the total number of rolls");
        System.Console.WriteLine("Total number of roles = " + totalRolls);

        for (int x = 2; x <=12; x++)
        {
            double percent = (double)results[x] / totalRolls * 100;
            int bars = (int)Math.Round(percent);

            System.Console.WriteLine(x + ": " + new string('*', bars));
        }
    }
}