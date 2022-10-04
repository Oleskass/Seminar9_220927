// ===============================================================
// #63 Задайте значение N и напишите программу, которая выдаёт 
// все натуральные числа в промежутке от 1 до N
// ===============================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//вызов intNum   outLine
//  1      4     4 3 2 1 ""
//  2      3     3 2 1 ""
//  3      2     2 1 ""
//  4      1     1 ""
//  5      0

//от N до 1
string LineGenRecDesc(int numN)
{
    //Точка остановки
    if (numN <= 0) return "";
    string outLine = numN + " " + LineGenRecDesc(numN - 1);
    return outLine;
}

//от 1 до N
string LineGenRec(int numN)
{
    //Точка остановки
    if (numN <= 0) return "";
    string outLine = LineGenRec(numN - 1) + " " + numN;
    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLineDesc = LineGenRecDesc(numN);
string resultLine = LineGenRec(numN);
PrintResult(resultLineDesc);
PrintResult(resultLine);