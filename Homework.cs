Console.Write("Enter Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double kelvin = celsius + 273.15;
double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine("Kelvin: " + kelvin.ToString("F2"));
Console.WriteLine("Fahrenheit: " + fahrenheit.ToString("F2"));

Console.WriteLine();

Console.Write("First grade: ");
double grade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Second grade: ");
double grade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Third grade: ");
double grade3 = Convert.ToDouble(Console.ReadLine());

double sum = grade1 + grade2 + grade3;
double average = sum / 3;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Average: " + average);
Console.WriteLine("Average >= 60: " + (average >= 60));

Console.WriteLine();

Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 100;
int second = number / 10 % 10;
int third = number % 10;

Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);