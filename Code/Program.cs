// variation#1
/*
string[] array = { "hello", "2", "world", ":-)", "**", "000" };
string[] finalArray = new string[6];
string temporaryArray = String.Empty;
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    temporaryArray = array[i];
    int length = temporaryArray.Length;
    int count = 0;
    while (length > 0)
    {
        count++;
        length--;
    }
    if (count <= 3)
    {
        finalArray[index] = temporaryArray;
        index++;
    }
}
PrintArray(finalArray);


void PrintArray(string[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

// variation#2
string[] array = { "hello", "2", "world", ":-)", "**", "00!3" };
string[] finalArray = new string[6];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        finalArray[index] = array[i];
        index++;
    }
}
PrintArray(finalArray);


string[] array = { "hello", "2", "world", ":-)", "**", "00!0" };
string[] finalArray = new string[6];
SortArray(array, finalArray);
PrintArray(finalArray);

string[] SortArray(string[] array, string[] finalArray)
{
    string arraySecond = String.Empty;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arraySecond = array[i];
        int length = arraySecond.Length;
        int count = 0;
        while (length > 0)
        {
            count++;
            length--;
        }
        if (count <= 3)
        {
            finalArray[index] = arraySecond;
            index++;
        }
    }
    return finalArray;
}
*/

Task();

void Task()
{
    Console.WriteLine();
    Console.WriteLine("Задайте размер массива. Введите целое число:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    string[] finalArray = new string[size];
    FillArray(array, size);
    SortArray(array, finalArray);
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Вывод отсортированного массива: ");
    PrintArray(finalArray);
    Console.WriteLine();
}

string[] FillArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] array, string[] finalArray)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            finalArray[index] = array[i];
            index++;
        }
    }
    return finalArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}