using Questions;

internal class Program
{
    private static void Main(string[] args)
    {
        Run();
    }
    public static void Run()
    {
        string input;

        Console.WriteLine("Select between 1 - 3 or X for the following questions:");
        Console.WriteLine("1 - Fibonacci");
        Console.WriteLine("2 - Distributor pt1");
        Console.WriteLine("3 - Distributor pt2");
        Console.WriteLine("4 - String inverter");
        Console.WriteLine("X - Exit");
        Console.WriteLine();

        input = Console.ReadLine().Trim();

        if (input == null || input == "")
        {
            Console.WriteLine("Input cannot be null");
            Run();
        }
        switch (input.ToLower())
        {
            case "1":
                new Fibonacci();
                break;
            case "2":
                var dis = new Distributor();
                dis.pt1();
                break;
            case "3":
                var dis2 = new Distributor();
                dis2.pt2();
                break;
            case "4":
                new Inverter();
                break;
        }
    }
}