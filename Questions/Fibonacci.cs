namespace Questions;

public class Fibonacci
{
    private int ValueToFind = 0;

    public Fibonacci()
    {
        Console.WriteLine("---- Fibonacci ----");
        Console.WriteLine("");
        Console.WriteLine("Digite um valor para acharmos na sequencia fibonacci (ou não); 'X' para sair");

        string? value = Console.ReadLine();

        if (value != null || value != "")
        {
            if (value.ToLower() != "x")
            {
                ValueToFind = int.Parse(value);
                Calc();
            }
            else
                Program.Run();
        }
    }

    public void Calc()
    {
        //F(n) = F(n-1) + F(n-2);
        int Counter = 100;
        string Sequence = "";

        //generating the sequence with 100 values;
        int A = 0, B = 1, C = 0;
        for (int i = 2; i < Counter; i++)
        {
            C = A + B;
            Sequence += $" {C} ";
            A = B;
            B = C;
        }

        if (Sequence.Contains(ValueToFind.ToString()))
            Console.WriteLine("The value exists on the Fibonacci Sequence");
        else
        {
            Console.WriteLine("The value DOES NOT exists on the Fibonacci Sequence");
        }
    }
}
