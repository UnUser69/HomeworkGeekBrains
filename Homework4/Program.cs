﻿/*

// Write a loop that takes two numbers (A and B) as input and raises A to the power of B. //
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
Console.WriteLine($"The answer is: {desired}.");

*/

/*

// Write a program that takes a number as input and returns the sum of the digits in the number. //
// Displaying a message on the screen. //
Console.Write("Enter the number: ");
// Input variable "number". //
int number = Convert.ToInt32(Console.ReadLine());
// Input variable "memory". //
int memory = 0;
// Input variable "counter". //
int counter=10;
// Running a loop to calculate the sum of the digits of a number. //
while (number>0){
// Starting a branch. //
if (number%counter>0){
    // Running a "for" loop. // 
    for (counter=10; number%counter>0; counter=10){
    // Summation of the remainder. //
    memory += number%counter;
    // Abbreviation for "number" variable. //
    number /= counter;
    }}
else {
    // Starting a branch. //
    if(number/counter>0){
        // Running a "while" loop. //
        while (number%counter==0){
            // Abbreviation for "number" variable. //
            number /= counter;
        }
        // Running a "for" loop. //
        for (counter=10; number%counter>0; counter=10){
        // Summation of the remainder. //
        memory += number%counter;
        // Abbreviation for "number" variable. //
        number /= counter;
        }}
    else{
        // Assigning the variable "memory" the value 0. //
        memory = 0;
    }
    }}
// Displaying a message on the screen. //
Console.WriteLine($"The answer is: {memory}.");

*/