void ChangeArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[4] {"hello", "2", "world", ":-)"};
PrintArray(array);
string[] array2 = new string[array.Length];
ChangeArray(array, array2);
PrintArray(array2);
