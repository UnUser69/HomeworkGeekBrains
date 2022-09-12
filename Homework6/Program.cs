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