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