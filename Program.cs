// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Vvedite znachenie N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite znachenie M: ");
int m = Convert.ToInt32(Console.ReadLine());

int akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return akkerman(n - 1, 1);
    else return akkerman(n - 1, akkerman(n, m - 1));
}

Console.Write($"Funkciya Akermana ravno {akkerman(n, m)} ");
