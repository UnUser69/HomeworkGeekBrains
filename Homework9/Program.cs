/*

// Give M and N values. Write a program that prints all natural numbers between M and N. //
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
        
*/

/*

// Give M and N values. Write a program that determines the number of natural elements between M and N. //
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int sum = 0;
if (M>N)
    for (int i = N; i <= M; i++)
        sum = sum+i;
else
    for (int i = M; i <= N; i++)
        sum = sum+i;

Console.Write($"{sum}");

*/

/*

// Write a program to tune the Ackerman functions using recursion. Two non-negative numbers m and n are given. //
int goal = 0;
int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
            else {
			    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
            }
		}
int one = Convert.ToInt32(Console.ReadLine());
int two = Convert.ToInt32(Console.ReadLine());
int answer = AkkermanFunc(one, two);
Console.WriteLine(answer);

*/
	