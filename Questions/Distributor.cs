using Newtonsoft.Json;

namespace Questions;

public class Distributor
{
    List<Billing> billing = new();
    public Distributor()
    {
        Console.WriteLine("------ Distribuitor ------");
        Console.WriteLine("");

        // Insert the full path here
        string FilePath = "C:/.../TargetQuestions/dados.json";
        billing = JsonConvert.DeserializeObject<List<Billing>>(File.ReadAllText(FilePath));

        Console.WriteLine("");
    }

    public void pt1()
    {
        decimal helper = 0;
        int days = 0;

        //• O menor valor de faturamento ocorrido em um dia do mês;
        helper = billing[0].valor;
        foreach (var b in billing)
        {
            if (b.valor > 0.0M)
            {
                if (helper > b.valor)
                {
                    helper = b.valor;
                }
            }
        }
        Console.WriteLine($"Lowest value: {helper}");

        //• O maior valor de faturamento ocorrido em um dia do mês;
        helper = billing[0].valor;
        foreach (var b in billing)
        {
            if (b.valor > 0.0M)
            {
                if (helper < b.valor)
                {
                    helper = b.valor;
                }
            }
        }
        Console.WriteLine($"Highest value: {helper}");

        //• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
        billing.RemoveAll(x => x.valor == 0.0M);

        //calc average
        helper = 0;
        foreach (var b in billing)
        {
            helper += b.valor;
        }
        helper = (helper / billing.Count());

        foreach (var b in billing)
        {
            if (b.valor >= helper)
                days++;
        }

        Console.WriteLine($"Average value: {((float)helper)}");
        Console.WriteLine($"Number of days that have values equal to or greater than average profit: {days}");
    }

    public void pt2()
    {
        // SP – R$67.836,43
        // RJ – R$36.678,66
        // MG – R$29.229,88
        // ES – R$27.165,48
        // Outros – R$19.849,53
        //------------------
        //67836.43M, 36678.66M, 29229.88M, 27165.48M, 19849.53M


        // State,  average, percent
        List<Tuple<string, decimal, float>> AverageByState = new();
        decimal total = 0;

        AverageByState.Add(new Tuple<string, decimal, float>("SP", 67836.43M, 0));
        AverageByState.Add(new Tuple<string, decimal, float>("RJ", 36678.66M, 0));
        AverageByState.Add(new Tuple<string, decimal, float>("MG", 29229.88M, 0));
        AverageByState.Add(new Tuple<string, decimal, float>("ES", 27165.48M, 0));
        AverageByState.Add(new Tuple<string, decimal, float>("Outros", 19849.53M, 0));

        foreach (var a in AverageByState)
        {
            total += a.Item2;
        }
        for (int i = 0; i < AverageByState.Count; i++)
        {
            Tuple<string, decimal, float>? b = AverageByState[i];
            var index = AverageByState.FindIndex(x => x == b);

            AverageByState[index] = new Tuple<string, decimal, float>
            (b.Item1, b.Item2, (float)(b.Item2 / total));
        }

        Console.WriteLine("Percentages: ");
        foreach (var x in AverageByState)
        {
            Console.WriteLine
            ($"    State(s): {x.Item1} - Average profit: {x.Item2} - Profit share: {(x.Item3 * 100).ToString("00.00")}%");
        }
    }

    public class Billing
    {
        public int dia { get; set; }
        public decimal valor { get; set; }
    }
}