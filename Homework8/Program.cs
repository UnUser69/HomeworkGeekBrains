/*

// Specify a two-dimensional array. Write a program to sort in descending order the elements of each row of a two-dimensional array. //
int m = Convert.ToInt32(Console.ReadLine());
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
int m = Convert.ToInt32(Console.ReadLine());
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
FillArray(TwoDimensionalArray);
PrintArray(TwoDimensionalArray);

int minSumLine = 0;
int sumLine = SumLineElements(TwoDimensionalArray, 0);
for (int i= 1; i < TwoDimensionalArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(TwoDimensionalArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

*/



// Write a program that fills a 4 by 4 array helix. //

int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

