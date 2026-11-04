
double[] week = { 14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4 };

double Average(double[] t)
{
    double x = 0;

    for (int i = 0; i < t.Length; i++)
    {
        x = x + t[i];
    }

    return x / t.Length;
}

double avg = Average(week);
Console.WriteLine("Average: " + avg.ToString("F1"));

int y = 0;

for (int i = 1; i < week.Length; i++)
{
    if (week[i] > week[y])
    {
        y = i;
    }
}

Console.WriteLine("Hottest Day: " + (y + 1));
Console.WriteLine("Temperature: " + week[y]);

Console.WriteLine("Above Average:");

for (int i = 0; i < week.Length; i++)
{
    if (week[i] > avg)
    {
        Console.WriteLine("Day " + (i + 1) + ": " + week[i]);
    }
}

Console.WriteLine("Last 3 Days:");

double[] x = week[^3..];

for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(x[i]);
}
