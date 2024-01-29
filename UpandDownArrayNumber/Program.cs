// See https://aka.ms/new-console-template for more information
int[] myArray = new int[100];

for (int i = 0;i <= 100; i++)
{
    Console.Write($"Enter Number {i} : ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Max Number : {myArray.Max()}");
Console.WriteLine($"Min Number : {myArray.Min()}");