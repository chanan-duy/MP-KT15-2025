namespace MP_KT15_2025;

public static class Logic
{
    private static void PrintNewLine()
    {
        Console.Write(Environment.NewLine);
    }

    private static void RunFibonacci()
    {
        var fib = new Fibonacci(10);
        var counter = 1;

        foreach (var num in fib)
        {
            Console.WriteLine($"{counter}. {num}");
            counter += 1;
        }
    }

    private static void RunMatrix()
    {
        var matrix = new Matrix(3, 4);
        Console.WriteLine("full matrix:");
        Console.WriteLine(matrix);

        Console.WriteLine("row 2:");
        foreach (var num in matrix.GetRow(2))
        {
            Console.Write($"{num:F3} ");
        }

        PrintNewLine();

        Console.WriteLine("col 0:");
        foreach (var num in matrix.GetColumn(0))
        {
            Console.Write($"{num:F3} ");
        }

        PrintNewLine();

        Console.WriteLine("col 1:");
        foreach (var num in matrix.GetColumn(1))
        {
            Console.Write($"{num:F3} ");
        }

        PrintNewLine();
    }

    public static void Run()
    {
        RunFibonacci();
        PrintNewLine();

        RunMatrix();
        PrintNewLine();
    }
}

public static class Program
{
    public static void Main(string[] _)
    {
        Logic.Run();
    }
}
