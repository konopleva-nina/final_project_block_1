void ResaltArray(string[] array2, string[] array, int n, int nums)
{
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
}

Console.Clear();
Console.Write("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int nums = 0; // количество вхождений строки с символами <= 3
for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine()!; 
        if (array[i].Length <= 3)
        {
            nums++;
        }  
    }
Console.WriteLine($"Mассив исходный: [{string.Join(", ", array)}]");
string[] array2 = new string[nums];
ResaltArray(array2, array, n, nums);
Console.WriteLine($"Результирущий массив: [{string.Join(", ", array2)}]");