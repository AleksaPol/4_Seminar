
void Zadacha25()
{   //Используя определение степени числа, 
    //напишите цикл, который принимает на вход два натуральных числа (A и B) 
    //и возводит число A в степень B.
    Console.WriteLine("_____________________");
    Console.WriteLine("Задача 25: ");
    Console.WriteLine("Введите число A: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    Power(result, num1, num2);

    void Power(int result, int num1, int mum2)
    {
        for (int i = 1; i <= num2; i++)
        {
            result = result * num1;
        }
        Console.WriteLine($"{num1} в степени {num2} = {result}");
    }
}
Zadacha25();

void Zadacha26()
{
    //Напишите программу, которая принимает на вход 
    //число и выдаёт сумму цифр в числе.
    Console.WriteLine("_____________________");
    Console.WriteLine("Задача 26: ");
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int current_num = num;
    while (current_num > 0)
    {
        int last_number = current_num % 10;
        result = last_number + result;
        current_num /= 10;
    }
    Console.WriteLine($"Cумма цифр числа {num} = {result}");
}
Zadacha26();

void Zadacha29()
{
    // Напишите программу, которая задаёт массив из 8 случайных целых чисел 
    // и выводит отсортированный по модулю массив.
    Console.WriteLine("___________________");
    Console.WriteLine("Задача 29");
    Console.Write("Задан массив из 8-ми случайных чисел: ");
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.Write(" \nОтсортированный по модулю массив: ");
    SortArray(numbers);
    PrintSortArray(numbers);
}
void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-100, 100);
    }
}
void PrintArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
}
void SortArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
            {
                int temp = (numbers[i]);
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
}
void PrintSortArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
}
Zadacha29();