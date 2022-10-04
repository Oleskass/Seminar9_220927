// =================================================================
// #66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// =================================================================

// запрашивает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintResult(int res)
{
    Console.WriteLine(res);
}

// показывает сумму чисел от M до N
int SumRec(int numM, int numN)
{
    if (numM >= numN) return numN; // точка остановки
    int outLine = numM + SumRec(numM + 1, numN);
    return outLine;
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = 0;
if (numM < numN) result = SumRec(numM, numN);
else result = SumRec(numN, numM);
PrintResult(result);