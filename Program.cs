using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

const string EXIT_SYMBOL = "q";

Console.WriteLine($"Введите '{EXIT_SYMBOL}' для выхода");
Console.WriteLine();

while (true)
{
    Console.Write("Введите первое число: ");
    string input1 = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(input1))
    {
        Console.WriteLine("Ошибка: ввод не может быть пустым");
        continue;
    }
    if (input1 == EXIT_SYMBOL)
    {
        break;
    }
    if (!double.TryParse(input1, out double a))
    {
        Console.WriteLine("Ошибка: введите корректное число");
        continue;
    }

    Console.Write("Введите второе число: ");
    string input2 = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(input2))
    {
        Console.WriteLine("Ошибка: ввод не может быть пустым");
        continue;
    }
    if (input2 == EXIT_SYMBOL)
    {
        break;
    }
    if (!double.TryParse(input2, out double b))
    {
        Console.WriteLine("Ошибка: введите корректное число");
        continue;
    }

    Console.WriteLine("Выберите операцию (+, -, *, /): ");
    string op = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(op))
    {
        Console.WriteLine("Ошибка: ввод не может быть пустым");
        continue;
    }
    if (op == EXIT_SYMBOL)
    {
        break;
    }
    double result;
    switch (op)
    {
        case "+":
            result = a + b;
            Console.WriteLine($"Результат: {a} + {b} = {result}");
            break;
        case "-":
            result = a - b;
            Console.WriteLine($"Результат: {a} - {b} = {result}");
            break;
        case "*":
            result = a * b;
            Console.WriteLine($"Результат: {a} * {b} = {result}");
            break;
        case "/":
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль");
                break;
            }
            result = a / b;
            Console.WriteLine($"Результат: {a} / {b} = {result}");
            break;
        default:
            Console.WriteLine("Ошибка: введите корректную операцию");
            break;
    }
}
