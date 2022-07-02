namespace Questions;

public class Inverter
{
    string input;
    public Inverter()
    {
        Console.WriteLine("------ String inverter ------");
        Console.WriteLine("");
        Console.WriteLine("Enter a text to be inverted; 'X' to exit");

        string? value = Console.ReadLine();

        if (value != null || value != "")
        {
            if (value.ToLower() != "x")
            {
                input = value;
                OfString();
            }
            else
                Program.Run();
        }
    }

    public void OfString()
    {
        int counter = 0;
        char[] ToInvert = input.ToCharArray();
        char[] Inverted = new char[ToInvert.Length];
        string Output = "";

        for (int i = ToInvert.Length - 1; i != -1; i--)
        {
            Inverted[counter] = ToInvert[i];
            counter++;
        }

        foreach(char c in Inverted)
        {
            Output += c;
        }

        Console.WriteLine();
        Console.WriteLine($"The inverted text: '{Output}'");
    }
}