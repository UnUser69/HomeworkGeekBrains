

// Displaying a message on the screen. //
Console.Write("Enter natural number: ");
// Entering a variable denoting the number. //
int number = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Enter the degree of a natural number: ");
// Entering a variable denoting the degree. //
int gradd = Convert.ToInt32(Console.ReadLine());
// The variable of the desired answer is entered. //
int desired = 1;
// The "for" loop is executed for raising a natural number to a power. //
for(int counter=1; counter<=gradd; counter++){
    // Exponentiation. //
    desired*=number;
}
// Displaying a message on the screen. //
Console.WriteLine($"The answer is {desired}.");

