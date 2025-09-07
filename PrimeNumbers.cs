using System.Collections;

namespace MP_KT15_2025;

public class PrimeNumbers : IEnumerator<int>
{
    private const int InitialPrimeNumber = 2;

    public int Current { get; private set; } = InitialPrimeNumber;

    int IEnumerator<int>.Current => Current;

    object IEnumerator.Current => Current;


    public bool MoveNext()
    {
        var num = Current;

        while (num < int.MaxValue)
        {
            var isPrime = true;
            num += 1;
            for (var i = 2; i <= num / 2; i++)
            {
                if (num % i != 0)
                {
                    continue;
                }

                isPrime = false;
                break;
            }

            if (isPrime)
            {
                Current = num;
                return true;
            }
        }

        return false;
    }

    public void Reset()
    {
        Current = InitialPrimeNumber;
    }


    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
