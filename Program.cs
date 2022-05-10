/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

string[] stringArray = {"Hello", "my", "dear", "frend", ". ", "How", "are", "you", "?"};
int len = stringArray.Length;

int count = 0;

for (int index = 0; index < len; index++)
{
    if (stringArray[index].Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];
count = 0;

for (int index = 0; index < len; index++)
{
    if (stringArray[index].Length <= 3)
    {
        newArray[count] = stringArray[index];
        count++;
    }
}

void ShowArray(string[] array)
{
    int len = array.Length;
    Console.Write("{");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"'{array[i]}'");
        if (i < len - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("}");
}

Console.WriteLine("\nДанный массив:");
ShowArray(stringArray);
Console.WriteLine("\nМассив после обработки:");
ShowArray(newArray);
