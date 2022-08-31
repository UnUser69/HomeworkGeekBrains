/*
// Write a program that takes a five-digit number as input and checks if it is a palindrome. //
// The program asks the user to enter a five-digit number. //
Console.Write("Enter a five-digit number: ");
// Variable initialization "FiveDigitNumber". //
int FiveDigitNumber = Convert.ToInt32(Console.ReadLine());
    // A loop is started from which you can exit if you only enter a five-digit number. //
    while (FiveDigitNumber<9999 || FiveDigitNumber>100000){
        // A message is displayed on the screen. //
        Console.WriteLine("It's not a five digit number. ");
        // The program asks the user to enter a five-digit number. //
        Console.Write("Enter a five-digit number: ");
        // Variable "FiveDigitNumber" is assigned a new value. //
        FiveDigitNumber = Convert.ToInt32(Console.ReadLine());
    }
// The string "number" is assigned the value of the variable "FiveDigitNumber". //
string number = Convert.ToString(FiveDigitNumber);
    // Branching starts. //
    if(number[0]==number[4] && number[1]==number[3]){
        // A message is displayed on the screen. //
        Console.Write("This number is a palindrome.");
        }
    else{
        // A message is displayed on the screen. //
        Console.Write("This number isn't a palindrome.");
        }

*/


