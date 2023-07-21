int n = int.Parse(Console.ReadLine());
int[] myArray = new int[n];

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    myArray[i] = number;
}

for (int i = myArray.Length - 1; i >= 0; i--)
{
    Console.Write(myArray[i] + " ");
}