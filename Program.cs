int num;
int num2;

Console.Write("Enter the first number: ");

num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");

num2 = Convert.ToInt32(Console.ReadLine());

int maxNumber = Math.Max(num, num2);

Console.Write("The maximum number is the number: ");

Console.WriteLine(maxNumber);

int minNumber = Math.Min(num, num2);

Console.Write("The minimum number is the number: ");

Console.WriteLine(minNumber);

