/*

// Specify a two-dimensional array. Write a program to sort in descending order the elements of each row of a two-dimensional array. //
// Displaying a message on the screen. //
Console.Write("Specify Number of Rows of Two-Dimensional Array: ");
// Variable "m" initialization. //
int m = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Specify Number of Columns of Two-Dimensional Array:");
int n = Convert.ToInt32(Console.ReadLine());
// Array initialization. //
int[,] TwoDimensionalArray = new int[m, n];
// Assigning the variable "rnd" the value of the function "new Random()". //
Random rnd = new Random();
// Initializing an Array Output Function. //
void PrintArray(int[,] array){ 
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
void FillArray(int[,] array){ 
    // Start cycle "for". //
    for (int i = 0; i < m; i++){ 
        // Running an additional "for" loop. //
        for (int j = 0; j < n; j++){ 
        // Filling array "array". //    
        array[i,j] = Convert.ToInt32(rnd.Next(-100, 100));}
    }
}
// Running the "FillArray" Function. //
FillArray(TwoDimensionalArray);
// Line break. //
Console.WriteLine();
// Running the "PrintArray" Function. //
PrintArray(TwoDimensionalArray);
// Running the "OrderArrayLines" Function. //
void OrderArrayLines(int[,] array)
{
    // Start cycle "for". //
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Running an additional "for" loop. //
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Running an additional "for" loop. //
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                // Branch initialization. //
                if (array[i, k] < array[i, k + 1]){
                // Writing an array value to a memory location. //
                int temp = array[i, k + 1];
                // Permutations in an array. //
                array[i, k + 1] = array[i, k];
                // Permutations in an array. //
                array[i, k] = temp;
                }
            }
            }
        }
        }
// Running the "OrderArrayLines" Function. //
OrderArrayLines(TwoDimensionalArray);
// Line break. //
Console.WriteLine();
// Running the "PrintArray" Function. //
PrintArray(TwoDimensionalArray);

*/

/*

// Specify a rectangular two-dimensional array. Write a program to find the string with the smallest sum of elements. //
// Displaying a message on the screen. //
Console.Write("Specify Number of Rows of Two-Dimensional Array: ");
// Variable "m" initialization. //
int m = Convert.ToInt32(Console.ReadLine());
// Displaying a message on the screen. //
Console.Write("Specify Number of Columns of Two-Dimensional Array:");
int n = Convert.ToInt32(Console.ReadLine());
// Array initialization. //
int[,] TwoDimensionalArray = new int[m, n];
// Assigning the variable "rnd" the value of the function "new Random()". //
Random rnd = new Random();
// Initializing an Array Output Function. //
void PrintArray(int[,] array){ 
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
void FillArray(int[,] array){ 
    // Start cycle "for". //
    for (int i = 0; i < m; i++){ 
        // Running an additional "for" loop. //
        for (int j = 0; j < n; j++){ 
        // Filling array "array". //    
        array[i,j] = Convert.ToInt32(rnd.Next(-100, 100));}
    }
}
// Running the "FillArray" Function. //
FillArray(TwoDimensionalArray);
// Line break. //
Console.WriteLine();
// Running the "PrintArray" Function. //
PrintArray(TwoDimensionalArray);
// Variable minimum sum initialization. //
int minSumLine = 0;
// Variable initialization. //
int sumLine = SumLineElements(TwoDimensionalArray, 0);
// Initializing the "for" function to find the smallest sum of an array string. //
for (int i= 1; i < TwoDimensionalArray.GetLength(0); i++)
{
  // Initializing a variable and assigning it the value of another variable. //
  int tempSumLine = SumLineElements(TwoDimensionalArray, i);
  // Triggering an "if" branch. //
  if (sumLine > tempSumLine)
  {
    // Assigning a new value to a variable. //
    sumLine = tempSumLine;
    // Assigning a new value to a variable. //
    minSumLine = i;
  }
}
// Displaying a message on the screen. //
Console.WriteLine($"{minSumLine+1} - row with the smallest sum ({sumLine}) elements.");
// Function initialization for finding the sum of an array string. //
int SumLineElements(int[,] array, int i)
{
// Assigning a variable the value of the first element of an array string. //
int sumLine = array[i,0];
    // Running the ""for" loop. //
    for (int j = 1; j < array.GetLength(1); j++)
    {
        // Finding the sum of the elements of an array row. //
        sumLine += array[i,j];
    }
// Returning the value of the "sumLine" variable. //
return sumLine;
}

*/

/*

// Write a program that fills a 4 by 4 array helix. //
// Initialization of the variable "n". //
int n = 4;
int[,] array = new int[n, n];
// Initialization of the variable "temp". //
int temp = 1;
// Initialization of the variable "i". //
int i = 0;
//Initialization of the variable "j". //
int j = 0;
// Running a "while" loop. //
while (temp <= array.GetLength(0) * array.GetLength(1)){
// Assigning the value of the variable "temp" to the first element of the array. //
array[i, j] = temp;
// Increase the "temp" variable by one. //   
temp++;
    // Triggering a branch to create a spiral. //
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        // Increase the "j" variable by one. //  
        j++;
    // Branch condition. //
    else if (i < j && i + j >= array.GetLength(0) - 1)
        // Increase the "i" variable by one. //      
        i++;
    // Branch condition. //
    else if (i >= j && i + j > array.GetLength(1) - 1)
        // Decrease variable "j" by one. //
        j--;
    // Branch condition. //
    else
        // Decrease variable "i" by one. //
        i--;
}
// Initializing an Array Output Function. //
void PrintArray(int[,] array){ 
    // Start cycle "for". //
    for (int i = 0; i < array.GetLength(0); i++){ 
        // Running an additional "for" loop. //
        for (int j = 0; j < array.GetLength(1); j++){ 
            // Array string output. //   
            if (array[i,j] / 10 <= 0)
                // Displaying a message on the screen. //
                Console.Write($" {array[i,j]} ");
            // Branch condition. //
            else 
                // Displaying a message on the screen. //
                Console.Write($"{array[i,j]} ");
            } 
        // Line break. //     
        Console.WriteLine();
    }
}
// Function launch. //
PrintArray(array);

*/