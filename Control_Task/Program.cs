Console.Write("Введите данные через пробел: ");
string[] date = Console.ReadLine().Split(' ');
string[] result = new string[date.Length];
void ResultArray(string[] date, string[] result)
{
    int count = 0;
    for (int i = 0; i < date.Length; i++)
    {
        if(date[i].Length <= 3)
        {
            result[count] = date[i];
            count++;
        }
    }
}
void OutputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(date, result);
OutputArray(result);
