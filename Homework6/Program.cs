/*

// The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered. //

// Displaying a message on the screen. //
Console.Write("Enter the number of input elements: ");
// Assigning the variable size to the value entered by the user. //
int size = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write($"Enter {size} elements: ");
// Function initialization "CreateArray". //
int [] CreateArray(){
    // Array initialization. //
    int[] array = new int[size];
    // Running a "for" loop to fill an array. //
    for(int i=0; i<size; i++){
        // User input. //
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    // Return value of array. //
    return array;
}

// Initialization of the counter "count". //
int count = 0;
// Assigning and reinitializing an array. //
int [] array = CreateArray();
// Running a background loop to count numbers greater than 0. //
for (int i = 0; i < array.Length; i++){
    // Loop condition. //
    if (array[i] > 0){
        // Increase the counter by one when the conditions are met. //
        count++;
    }
}
// Displaying a message on the screen. // 
Console.WriteLine($"Number of elements > 0: {count}");

*/

/*

// Write a program that will find the point of intersection of two lines given by the equations y = k1 * x + b1, y = k2 * x + b2; the values ​​b1, k1, b2 and k2 are set by the user. //

// Function initialization "FindThePoint". //
void FindThePoint(){
    // A message is displayed on the screen. //
    Console.WriteLine($"I find the point of intersection of two lines given by the equations y = k1 * x + b1, y = k2 * x + b2.");
    // A message is displayed on the screen. //
    Console.Write($"Enter the value of the variable 'b1':");
    // The variable "b1" is assigned the value entered by the user. //
    float b1 = Convert.ToInt32(Console.ReadLine());
    // A message is displayed on the screen. //
    Console.Write($"Enter the value of the variable 'k1':");
    // The variable "k1" is assigned the value entered by the user. //
    float k1 = Convert.ToInt32(Console.ReadLine());
    // A message is displayed on the screen. //
    Console.Write($"Enter the value of the variable 'b2':");
    // The variable "b2" is assigned the value entered by the user. //
    float b2 = Convert.ToInt32(Console.ReadLine());
    // A message is displayed on the screen. //
    Console.Write($"Enter the value of the variable 'k2':");
    // The variable "k2" is assigned the value entered by the user. //
    float k2 = Convert.ToInt32(Console.ReadLine());
        // Starting a branch. //
        if(b1 == b2 && k1 ==k2){
            // A message is displayed on the screen. //
            Console.WriteLine($"Direct match.");
        }
        // Branch condition. //
        else{
            // Branch condition. //
            if(k1 == k2){
            // A message is displayed on the screen. //
            Console.WriteLine($"Straight lines are parallel.");
            }
            // Branch condition. //
            else{
            // Initializing and finding the value of the variable "x". //
            float x = (b2 - b1) / (k1 - k2);
            // Initializing and finding the value of the variable "y". //
            float y = k1 * x + b1;
            // A message is displayed on the screen. //
            Console.WriteLine($"Point of intersection of two coordinates: ({x}; {y}).");
            }
    }
}
// Function launch. //
FindThePoint();

*/

