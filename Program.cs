/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] array = { "Hello", "2", "world", ":-)" };
int count = 0;
int index = 0;
string temp = string.Empty;

PrintTextArray(array);

while(index < array.Length)
{
    temp = array[index];
    if (temp.Length <= 3)
    {
        count++;
    }
    index++;
}

string[] arrayNew = new string [count];
index = 0;
int indexNew = 0;

while(index < array.Length)
{
    temp = array[index];
    if(temp.Length <= 3)
    {
        arrayNew[indexNew] = array[index];
        indexNew++;
    }
    index++;
}

Console.Write(" -> ");
PrintTextArray(arrayNew);

void PrintTextArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length -1] + "]");
}
