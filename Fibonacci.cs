using System.Collections;

namespace MP_KT15_2025;

public class Fibonacci : IEnumerable<int>
{
    public int NumbersAmount { get; set; }

    public Fibonacci(int numbersAmount)
    {
        NumbersAmount = numbersAmount;
    }

    public IEnumerator<int> GetEnumerator()
    {
        var index = 0;

        if (index++ >= NumbersAmount)
        {
            yield break;
        }

        yield return 0;

        if (index++ >= NumbersAmount)
        {
            yield break;
        }

        yield return 1;

        var first = 0;
        var second = 1;

        while (index < NumbersAmount)
        {
            var current = first + second;
            (first, second) = (second, current);
            index += 1;
            yield return current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
