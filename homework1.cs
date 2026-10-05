Console.WriteLine("Hello C#");

Console.WriteLine("Name: Mahmut Ebuali");
Console.WriteLine("Department: CENG");
Console.WriteLine("Year: 2");

Console.WriteLine("Current date and time: " + DateTime.Now);

Console.Write("Enter Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine("Fahrenheit: " + fahrenheit);