/*

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

*/

//Write a program that displays the third digit of a given number, or reports that there is no third digit. //
int ThreeDigit(){
    // Displays a message. //
    Console.Write("Enter your three-digit number: ");
    // Prompts the user for input. //
    int Number = Convert.ToInt32(Console.ReadLine());
        // A branch is triggered to determine a three-digit number. //
        if(Number/100==0){
            // Displays a message. //
            Console.Write("The " + Number + " it isn't a three-digit number. I can't find the third number. ");
            // At the end of the branch, returns the value of the variable "Number". //
            return Number;
        }
        else{
            // At the end of the branch, returns the value of the variable "Number". //
            return Number;
        }
}
// Initializing a variable and assigning it the value of the "ThreeDigit" function. //
int Desired = ThreeDigit();
// A branch is created to display the result on the screen, depending on the initial value of the result. //
if(Desired/100==0){
     // Displays a message. //
    Console.Write("Your number doesn't have a third digit.");
}
else{
    if(Desired<0){
        // Finding the third digit of a number. //
        Desired=Desired/100%10;
        // The negative is removed from the variable. //
        Desired=-Desired;
        // Displays a message. //
        Console.Write("The third digit of your number is: " + Desired + ".");
    }
    else{
        // Finding the third digit of a number. //
        Desired=Desired/100%10;
        // Displays a message. //
        Console.Write("The third digit of your number is: " + Desired + ".");
    }
}
