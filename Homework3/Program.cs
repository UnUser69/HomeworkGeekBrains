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

/*
// Write a program that takes the coordinates of two points as input and finds the distance between them in 3D space. //
Console.Write("Enter the x coordinate of the first point: ");
// Input variable "x1". //
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y coordinate of the first point: ");
// Input variable "y1". //
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the z coordinate of the first point: ");
// Input variable "z1". //
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the x coordinate of the second point: ");
// Input variable "x2". //
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y coordinate of the second point: ");
// Input variable "y2". //
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the z coordinate of the second point: ");
// Input variable "z2". //
double z2 = Convert.ToDouble(Console.ReadLine());
// Assigning to the variable "Distance" the value of the formula for finding the distance between two points in space: √((x2−x1)^2+(y2−y1)^2+(z2−z1)^2). //
double Distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// Displaying the message and solution on the screen and rounding it to hundredths. //
Console.WriteLine("The distance between points in 3D space is: " + Math.Round(Distance,2) + ".");

*/

