/*

// Give M and N values. Write a program that prints all natural numbers between M and N. //
// Displaying a message on the screen. //
Console.Write("Enter the N-number: ");
// Initialization of the variable "N". //
int N = Convert.ToInt16(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Enter the M-number: ");
// Initialization of the variable "M". //
int M = Convert.ToInt16(Console.ReadLine());
// Displaying a message on the screen. //
Console.WriteLine($"N={N}, M={M}");
// Branch function initialization. //
if (M>N)
    // Cycle start. //
    for (int i = N; i <= M; i++)
        // Displaying numbers on the screen. //
        Console.Write($" {i}");
// Branch condition. //
else
    // Cycle start. //
    for (int i = M; i <= N; i++)
        // Displaying numbers on the screen. //
        Console.Write($" {i}");
        
*/

/*

// Give M and N values. Write a program that determines the number of natural elements between M and N. //
// Displaying a message on the screen. //
Console.Write("Enter the N-number: ");
// Initialization of the variable "N". //
int N = Convert.ToInt16(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Enter the M-number: ");
// Initialization of the variable "M". //
int M = Convert.ToInt16(Console.ReadLine());
// Displaying a message on the screen. //
Console.WriteLine($"N={N}, M={M}");
// Initialization of the variable "sum". //
int sum = 0;
// Branch function initialization. //
if (M>N)
    // Cycle start. //
    for (int i = N; i <= M; i++)
        // Assigning the variable "sum" the value of the sum of the elements. //
        sum = sum+i;
// Branch condition. //
else
    // Cycle start. //
    for (int i = M; i <= N; i++)
        // Assigning the variable "sum" the value of the sum of the elements. //
        sum = sum+i;
// Displaying a message on the screen. //
Console.Write($"{sum}");

*/

/*

// Write a program to tune the Ackerman functions using recursion. Two non-negative numbers m and n are given. //
// Initialization of the variable "goal". //
int goal = 0;
// Function initialization "AkkermanFunction". //
int AkkermanFunction(int m, int n)
{
    // Branch function initialization. //
    if(m == 0){
		// Assigning the function "AkkermanFunction" the value "n+1". //
        return n + 1;
		}
	// Branch condition. //
    if(m > 0 && n == 0){
		// Restart function "AkkermanFunction". //
        return AkkermanFunction(m - 1, 1);
		}
    // Branch condition. //        
    else{
		// Restart function "AkkermanFunction". //
        return AkkermanFunction(m - 1, AkkermanFunc(m, n - 1));
        }
}
// Initialization of the variable "one". //
int one = Convert.ToInt32(Console.ReadLine());
// Initialization of the variable "two". //
int two = Convert.ToInt32(Console.ReadLine());
// Initialization of the variable "answer". //
int answer = AkkermanFunction(one, two);
// Displaying a function on the screen. //
Console.WriteLine(answer);

*/
	