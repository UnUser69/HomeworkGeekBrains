// Write a program that includes a three-digit number of this number and, as a result, shows the second digit of the number. //
// Initializes a function. //
int ThreeDigit(){
    // Displays a message. //
    Console.Write("Enter your three-digit number: ");
    // Prompts the user for input. //
    int Number = Convert.ToInt32(Console.ReadLine());
        // A loop is started that asks for the correct answer: a three-digit number. //
        while(Number/100==0 || Number/100>9 || Number/100<-9){
            // The program displays text on the screen. //
            Console.Write("The " + Number + " it isn't a three-digit number.");
            // The program displays text on the screen. //
            Console.Write(" Enter your three-digit number: ");
            // Prompts the user for input. //
            Number = Convert.ToInt32(Console.ReadLine());
        }
    // At the end of the loop, returns the value of the variable "Number". //
    return Number;
}
// Initializing a variable and assigning it the value of the "ThreeDigit" function. //
int YourNumber = ThreeDigit();
// Finds the remainder of a number that is nominally equal to the second digit of the number. //
int Desired = YourNumber%100/10;
// Branching is started to convert negative numbers to a positive answer. //
if(Desired<0){
    // The negative is removed from the variable. //
    Desired=-Desired;
    // The program displays text on the screen. //
    Console.Write("The second digit of your number is: " + Desired + ".");
}
else {
    // The program displays text on the screen. //
    Console.Write("The second digit of your number is: " + Desired + ".");
}

