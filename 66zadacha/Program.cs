// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int nums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int nums2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = nums;

void Rec(int n, int m)
{
    if (m > n)
    {
        if (m == n)
        {
            return;
        }
        Rec(n, m - 1);
    }
    else if (m < n)
    {
    if (m == n) return;
    Rec(n - 1, m);
    }
}

void PrintSum(int m, int n, int sum)
{
    if (m > n) 
    {
    m = n;
    n = temp;
    }
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов равна: {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);
}

Rec(nums, nums2);
PrintSum(nums, nums2, sum);