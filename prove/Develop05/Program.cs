using System;

class Program
{
    private static List<Goal> _allGoals = new List<Goal>();
    private static int total_points = 0;
    static void Main(string[] args)
    {

        
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {total_points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("What would like to do? ");
            int prompt = int.Parse(Console.ReadLine() ?? "");
        }}}