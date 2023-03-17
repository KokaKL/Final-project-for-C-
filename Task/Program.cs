// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых <= 3.

string PromtString(string? msg)
{
    System.Console.Write(msg + "-> ");
    return Console.ReadLine();
}

int PromtInt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
}
string[] FillArray(string[] array)
{
    int i = 0;
    int num = 1;
    for (int x = 0; x < array.Length; x++)
    {
        array[i] = PromtString($"Введите фразу номер {num}");
        i++;
        num++;
    }
    return array;
}

int SizeNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}