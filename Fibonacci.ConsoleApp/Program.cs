// See https://aka.ms/new-console-template for more information

const int input = 15;

Console.WriteLine(CalculateFibonacci(input));

int CalculateFibonacci(int value)
{
    switch (value)
    {
        case <= 0:
            throw new ArgumentException("Value must be a positive integer.", nameof(value));
        case 1 or 2:
            return 1;
    }

    var previous = 1;
    var current = 1;

    for (var i = 3; i <= value; i++)
    {
        var next = previous + current;
        previous = current;
        current = next;
    }

    return current;
}
