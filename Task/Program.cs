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