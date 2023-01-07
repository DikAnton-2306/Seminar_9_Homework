// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void NumberPlus(int count)
{
    if (count >= 1)
    {
        System.Console.Write(count + " ");
        count--;
        NumberPlus(count);
    }
}
int count = EnterNumber("Введите число N");

NumberPlus(count);