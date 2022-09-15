/*

// Specify a two-dimensional m×n array filled with random real numbers. //
// Displaying a message on the screen. //
Console.Write("Specify Number of Rows of Two-Dimensional Array: ");
// Variable "m" initialization. //
int m = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Specify Number of Columns of Two-Dimensional Array:");
// Variable "n" initialization. //
int n = Convert.ToInt32(Console.ReadLine());
// Array initialization. //
double[,] TwoDimensionalArray = new double[m, n];
// Assigning the variable "rnd" the value of the function "new Random()". //
Random rnd = new Random();
// Initializing an Array Output Function. //
void PrintArray(double[,] array){ 
    // Start cycle "for". //
    for (int i = 0; i < m; i++){ 
        // Running an additional "for" loop. //
        for (int j = 0; j < n; j++){ 
        // Array string output. //   
        Console.Write($"{array[i, j]} ");}
    // Line break. //     
    Console.WriteLine();}
}
// Initializing functions to fill an array with random numbers. //
void FillArray(double[,] array){ 
    // Start cycle "for". //
    for (int i = 0; i < m; i++){ 
        // Running an additional "for" loop. //
        for (int j = 0; j < n; j++){ 
        // Filling array "array". //    
        array[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}
    }
}
// Running the "FillArray" Function. //
FillArray(TwoDimensionalArray);
// Line break. //
Console.WriteLine();
// Running the "PrintArray" Function. //
PrintArray(TwoDimensionalArray);

*/

/*

// Write a program that takes the position of an element in a two-dimensional array as input, and returns the value of this element or an indication that there is no such element. //
// Displaying a message on the screen. //
Console.Write("Enter the height of the array: ");
// Initialization of the "m" variable to indicate the height of the array. //
int m = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Enter the length of the array: ");
// Initialization of the "m" variable to indicate the width of the array. //
int n = Convert.ToInt32(Console.ReadLine());
// Array initialization. //
int[,] array = new int[m, n];
// Array height. //
for (int i = 0; i < m; i++) {   
    // Array length. //
    for (int j = 0; j < n; j++)
        // Filling an array with random numbers. //
        array [i, j] = Convert.ToInt32(new Random().Next(0,100));  
}
// Array height. //
for (int i = 0; i < m; i++) {
    // Array length. //
    for (int j = 0; j < n; j++)
        // Writes out the rows of an array. //
        Console.Write(array[i,j] + " ");
        // Array line wrap. //
        Console.WriteLine();
}
// Displaying a message on the screen. //
 Console.WriteLine("Enter the x coordinate of the point: ");
// Variable initialization "a". //
 int a = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
 Console.WriteLine("Enter the y coordinate of the point: ");
// Variable initialization "b". //
 int b = Convert.ToInt32(Console.ReadLine());
// Branch initialization. //
if (a>m || b>n){
    // Displaying a message on the screen. //
    Console.WriteLine("такого числа нет");
}
// Branch condition. //
else {
    // Finding an object. //
    object c = array.GetValue(a,b);
    // Line wrapping. //
    Console.WriteLine(c);
}

*/

/*

// Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column. //
// Displaying a message on the screen. //
Console.Write("Enter the height of the array: ");
// Initialization of the "m" variable to indicate the height of the array. //
int m = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Enter the length of the array: ");
// Initialization of the "m" variable to indicate the width of the array. //
int n = Convert.ToInt32(Console.ReadLine());
// Array initialization. //
int[,] array = new int[m, n];
// Array height. //
for (int i = 0; i < m; i++) {   
    // Array length. //
    for (int j = 0; j < n; j++)
        // Filling an array with random numbers. //
        array [i, j] = Convert.ToInt32(new Random().Next(0,100));  
}
// Array height. //
for (int i = 0; i < m; i++) {
    // Array length. //
    for (int j = 0; j < n; j++)
        // Writes out the rows of an array. //
        Console.Write(array[i,j] + " ");
        // Array line wrap. //
        Console.WriteLine();
}
// Loop initialization. //
for (int i = 0; i < m; i++) {
    // Arithmetic mean variable initialization. //
    int average = 0;
        // Cycle start. //
        for (int t = 0; t < n; t++){
            // Finding the arithmetic mean. //
            average += array[t, i];
            }
// Display message and value on screen. //
Console.WriteLine($"Arithmetic mean of column elements {i + 1} = {(float)average/n}");
}

*/

