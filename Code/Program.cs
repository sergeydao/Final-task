﻿// variation#1
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
*/ 

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