/*

// Specify a two-dimensional m×n array filled with random real numbers. //

Console.Write("Specify Number of Rows of Two-Dimensional Array: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Specify Number of Columns of Two-Dimensional Array:");

int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[m, n];

Random rnd = new Random();

void PrintArray(double[,] matr){ 
    
    for (int i = 0; i < m; i++){ 
        
        for (int j = 0; j < n; j++){ 
            
        Console.Write($"{matr[i, j]} ");}
        
    Console.WriteLine();}
}

void FillArray(double[,] matr){ 
    
    for (int i = 0; i < m; i++){ 
        
        for (int j = 0; j < n; j++){ 
            
        matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}
    }
}

FillArray(twoDimArray);

Console.WriteLine();

PrintArray(twoDimArray);

*/



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
 
 Console.WriteLine("Введите координаты");

 int a = Convert.ToInt32(Console.ReadLine());

 int b = Convert.ToInt32(Console.ReadLine());

 if (a>m || b>n)

 Console.WriteLine("такого числа нет");

 else
 {

 object c = array.GetValue(a,b);

 Console.WriteLine(c);
 }



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

