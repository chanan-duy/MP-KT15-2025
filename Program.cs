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

    public static void Run()
    {
        RunFibonacci();
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
