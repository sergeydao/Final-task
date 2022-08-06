// variation#1

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