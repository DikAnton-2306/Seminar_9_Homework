// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numM, int numN)
{
    if (numM == numN) return numN;
    return SumNumbers(numM + 1, numN) + numM;
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberM = EnterNumber("Введите число M: ");
int numberN = EnterNumber("Введите число N: ");

int sum = SumNumbers(numberM, numberN);
System.Console.WriteLine($"Сумма всех чисел от {numberM} до {numberN} равна {sum}");