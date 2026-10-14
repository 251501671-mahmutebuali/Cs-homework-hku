int count = 0;
double sum = 0;
double highest = 0;
double lowest = 0;

Console.Write("Enter a grade (-1 to stop): ");
double grade = Convert.ToDouble(Console.ReadLine());

while (grade != -1)
{
    if (count == 0)
    {
        highest = grade;
        lowest = grade;
    }

    if (grade > highest)
    {
        highest = grade;
    }

    if (grade < lowest)
    {
        lowest = grade;
    }

    sum = sum + grade;
    count++;

    Console.Write("Enter a grade (-1 to stop): ");
    grade = Convert.ToDouble(Console.ReadLine());
}

if (count > 0)
{
    double average = sum / count;

    Console.WriteLine($"Count: {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
}

Console.WriteLine();

Console.Write("Enter a number from 1 to 10: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}