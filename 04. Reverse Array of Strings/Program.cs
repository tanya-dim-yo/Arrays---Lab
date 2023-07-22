var elements = Console.ReadLine().Split(' ').ToArray();

for (int i = 0; i < elements.Length / 2; i++)
{
    var tempElement = elements[i];
    elements[i] = elements[elements.Length - 1 - i];
    elements[elements.Length - 1 - i] = tempElement;
}

Console.WriteLine(string.Join(" ", elements));