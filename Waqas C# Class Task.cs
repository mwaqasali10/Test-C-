// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

//Give Array = [1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38]

//Find the sum of all the integers in the array.
//Find the maximum and minimum values in the array.
//Count the number of even and odd integers in the array.
//Calculate the average of all the integers in the array.
//Check if a specific integer is present in the array.
//Create two dimensional Array.
//Create a program that finds the sum of all elements in a two-dimensional array (matrix).
//Write a function to calculate the area of a rectangle the length of the rectangle is 20cm and the width is 12cm.



//Sum of All Integer

int[] nums = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

int sum = 0;

for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
};

Console.WriteLine(sum);

//Maximum & Minimum Value in Array

int[] number = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

int max = number.Max();
Console.WriteLine(max);

int min = nums.Min();
Console.WriteLine(min);


//Count the number of even and odd integers in the array

int evenCount = 0;
int oddCount = 0;
foreach (int num in number)
{
    if (num % 2 == 0)
    { evenCount++; }
    else { oddCount++; }
}
Console.WriteLine("Number of even integers: " + evenCount);
Console.WriteLine("Number of odd integers: " + oddCount);


//Calculate the average of all the integers in the array.

int[] value = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

var Avg = value.Average();
Console.WriteLine(Avg);


//Check if a specific integer is present in the array.

int specificInteger = 97;
bool present = value.Contains(specificInteger);
Console.WriteLine(specificInteger + "is present" + present);

//Create two dimensional Array.

int[,] array2D = new int[3, 3]
{
    { 2,4,5 },
    { 3,4,5 },
    { 6,7,9 },
};
int row1 = array2D.GetLength(0);
int col = array2D.GetLength(1);

for (int i = 0; i < row1; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.WriteLine($"index {i}). {array2D[i, j]}");
    }
    Console.WriteLine();
}

//Create a program that finds the sum of all elements in a two-dimensional array (matrix).

int summ = 0;
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    { summ += array2D[i, j]; }
}
Console.WriteLine("Sum of all integers: " + summ);
Console.WriteLine("Sum of all elements in array2d: " + summ);


//Write a function to calculate the area of a rectangle the length of the rectangle is 20cm and the width is 12cm.

int length = 20;
int width = 12;
int Area = length * width;
Console.WriteLine($"Area of Rectangle is {Area}");





