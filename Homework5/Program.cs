/*

// Specify an array filled with random positive three-digit numbers. Write a program to show the number of even numbers in an array. //
int [] CreateRandomArray(int size){
    // Array initialization. //
    int[] array = new int[size];
    // Running a "for" loop to fill an array with random numbers. //
    for(int i=0; i<size; i++){
        // Three-digit number generation. //
        array[i] = new Random().Next(100, 1000);
    }
    // Displaying the value of the "array" variable. //
    return array;
}
// Input function "void". //
void ShowArray(int[] array){
    // Array filling loop. //
    for(int i=0; i<array.Length; i++){
        // Displaying an array on the screen. //
        Console.Write(array[i]+" ");
    }
}
// Displaying a message on the screen. //
Console.Write("Your array: ");
// Initialization of the "size" function. //
int size = Convert.ToInt32( new Random().Next(1,51));
// Declaring an array and assigning the values ​​of the "CreateRandomNumber" function to it. //
int[] second_array=CreateRandomArray(size);
// Function usage. //
ShowArray(second_array);
// Displaying a message on the screen. //
Console.Write("; ");
// Function creation //
int Parity(){
// Variable initialization "i". //
int i=0;
// Variable initialization "count". //
int count = 0;
// Launching a cycle for the occurrence of odd evenness of numbers. //
while(i<second_array.Length){    
    // Loop condition. //
    if (second_array[i]%2==0){
        // Increment counter "count". //
        count = count + 1;
        // Increment counter "i". //
        i = i+1;
    }
    // Loop condition. //
    else{
        // Increment counter "i". //
        i = i+1;
    }
}
// Displaying the value of the variable "count". //
return count;
};
// Initializing the "answer" variable and assigning it the value of the "Parity" function. //
int answer = Parity();
// Displaying a message on the screen. //
Console.WriteLine($"Number of even numbers in array: {answer};");

*/

/*

// Specify a one-dimensional array filled with random numbers. Find the sum of elements in odd positions. //
// Found array function "CreateRandomArray". //
int [] CreateRandomArray(int size){
    // Array initialization. //
    int[] array = new int[size];
    // Running a "for" loop to fill an array with random numbers. //
    for(int i=0; i<size; i++){
        // Random number generation. //
        array[i] = new Random().Next(-1001,1001);
    }
    // Displaying the value of the "array" variable. //
    return array;
}
// Input function "void". //
void ShowArray(int[] array){
    // Array filling loop. //
    for(int i=0; i<array.Length; i++){
        // Displaying an array on the screen. //
        Console.Write(array[i]+" ");
    }
}
// Displaying a message on the screen. //
Console.Write("Your array: ");
// Initialization of the "size" function. //
int size = Convert.ToInt32( new Random().Next(1,51));
// Declaring an array and assigning the values ​​of the "CreateRandomNumber" function to it. //
int[] second_array=CreateRandomArray(size);
// Function usage. //
ShowArray(second_array);
// Displaying a message on the screen. //
Console.Write("; ");
// Function creation //
int SumOfOddElements(){
// Variable initialization "i". //
int i=0;
// Variable initialization "sum". //
int sum = 0;
// Launching a loop to find the sum of elements in odd positions. //
while(i<second_array.Length){    
    // Loop condition. //
    if (i==0){
        // Increment counter "i". //
        i = i+1;
    }
    // Loop condition. //
    else{
        if(i%2==0){
            // Increment counter "i". //
            i = i+1; 
        }
        else{
            // Increment counter "sum". //
            sum += second_array[i];
            // Increment counter "i". //
            i = i+1;
        }
    }
}
// Displaying the value of the variable "sum". //
return sum;
};
// Initializing the "answer" variable and assigning it the value of the "SumOfOddElements" function. //
int answer = SumOfOddElements();
// Displaying a message on the screen. //
Console.WriteLine($"The sum of elements in odd positions is equal to: {answer};");

*/

/*

// Specify an array of real numbers. Find the difference between the maximum and minimum elements of the array. //
// Found array function "CreateRandomArray". //
int [] CreateRandomArray(int size){
    // Array initialization. //
    int[] array = new int[size];
    // Running a "for" loop to fill an array with random numbers. //
    for(int i=0; i<size; i++){
        // Random number generation. //
        array[i] = new Random().Next(1,1001);
    }
    // Displaying the value of the "array" variable. //
    return array;
}
// Input function "void". //
void ShowArray(int[] array){
    // Array filling loop. //
    for(int i=0; i<array.Length; i++){
        // Displaying an array on the screen. //
        Console.Write(array[i]+" ");
    }
}
// Displaying a message on the screen. //
Console.Write("Your array: ");
// Initialization of the "size" function. //
int size = Convert.ToInt32( new Random().Next(1,5));
// Declaring an array and assigning the values ​​of the "CreateRandomNumber" function to it. //
int[] second_array=CreateRandomArray(size);
// Function usage. //
ShowArray(second_array);
// Displaying a message on the screen. //
Console.Write("; ");
// Variable initialization "index". //
int index = 0;
// Variable initialization "max". //
int max = second_array[0];
// Variable initialization "min". //
int min = second_array[0];
// Function creation //
int MaximumArrayNumber(){
    // Running a loop to find the maximum element of an array. //
    while(index<second_array.Length){
        // Loop condition. //
        if(second_array[index]>=max){
            // Assigning a value to the variable "max". //
            max = second_array[index];
            // Counter increment. //
            index++;
        }
        // Loop condition. //
        else{
            // Counter increment. //
            index++;
        }
    }
    // Output of the final value of the variable "max". //
    return max;
}
int MinimumArrayNumber(){
    // Running a loop to find the minimum element of an array. //
    while(index<second_array.Length){
        // Loop condition. //
        if(second_array[index]<=min){
            // Assigning a value to the variable "min". //
            min = second_array[index];
            // Counter increment. //
            index++;
        }
    // Loop condition. //
    else{
            // Counter increment. //
            index++;
        }
    }
    // Output of the final value of the variable "min". //
    return min;
    }
// Initializing the variable "MaxNumber" and assigning it the value of the function "MaximumArrayNumber". //
int MaxNumber = MaximumArrayNumber();
// Initializing the variable "MinNumber" and assigning it the value of the function "MinimumArrayNumber". //
int MinNumber = MinimumArrayNumber();
// Variable initialization "Difference". //
int Difference = MaxNumber-MinNumber;
// Displaying a message on the screen. //
Console.WriteLine($"The difference between the maximum and minimum array elements: {Difference};");

*/