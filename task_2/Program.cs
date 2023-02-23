/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && (result >= 0))
        {
        break;
        }
        else
        {
        Console.WriteLine("Некорректный ввод");
        }
    }
    return result;
}


int PrintNumbers(int m, int n, int sum)
{
    if(m > n) return sum;
    else
    {
        return PrintNumbers(m + 1, n, sum += m);
    }
}

int numM = GetNumber("Введите натуральное число");
int numN = GetNumber("Введите натуральное число");
int sumMN = 0;

if(numM > numN) 
{
    Console.WriteLine("Первое число должно быть меньше второго");
}
else 
{
    Console.WriteLine($"{PrintNumbers(numM, numN, sumMN)}");
}