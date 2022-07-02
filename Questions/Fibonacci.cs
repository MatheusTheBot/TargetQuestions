namespace Questions;

public class Fibonacci
{
    private int ValueToFind = 0;

    public Fibonacci()
    {
        Console.WriteLine();
        Console.WriteLine("------ Fibonacci ------");
        Console.WriteLine("");
        Console.WriteLine("Enter a value to find it in the fibonacci sequence (or not); 'X' to exit");

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
        int QuantityOfValues = 45;
        long[] Sequence = new long[QuantityOfValues];
        bool Exists = false;

        //generating the sequence with 100 values;
        long A = 0, B = 1, C = 0, Index = 0;
        for (int i = 0; i < QuantityOfValues; i++)
        {
            C = A + B;
            Sequence[Index] = C;
            A = B;
            B = C;
            Index++;
        }

        foreach (var i in Sequence)
        {

            if (i == ValueToFind)
            {
                Console.WriteLine();
                Console.WriteLine("The value exists on the Fibonacci Sequence");
                Exists = true;
                break;
            }
        };

        if (Exists == false)
        {
            Console.WriteLine();
            Console.WriteLine("The value DOES NOT exists on the Fibonacci Sequence");
        }
    }
}
