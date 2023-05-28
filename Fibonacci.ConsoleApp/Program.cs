// See https://aka.ms/new-console-template for more information

const int input = 15;

// Assuming not console app memoization could be handy
var cache = new Dictionary<int, int>();

Console.WriteLine(CalculateFibonacci(input));
Console.WriteLine(CalculateFibonacci(input - 1));

int CalculateFibonacci(int value)
{
    switch (value)
    {
        case <= 0:
            throw new ArgumentException("Value must be a positive integer.", nameof(value));
        case 1 or 2:
            return 1;
    }

    if (cache.TryGetValue(value, out var result))
    {
        return result;
    }

    var previous = 1;
    var current = 1;

    for (var i = 3; i <= value; i++)
    {
        var next = previous + current;
        previous = current;
        current = next;

        cache[i] = current;
    }

    return current;
}
