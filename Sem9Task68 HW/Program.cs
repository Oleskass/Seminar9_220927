// =================================================================
// #68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// =================================================================

// запрашивает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// показывает сумму чисел от M до N
int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    else
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
}


int numM = ReadData("Введите неотрицательное число M: ");
int numN = ReadData("Введите неотрицательное число N: ");
if (numM >= 0 && numN >= 0)
{
    PrintResult($"Функция Аккермана A({numM},{numN}) = {AckermannFunc(numM, numN)}");
}
else 
{
    PrintResult("Ошибка! Используйте неотрицательные числа.");
}


