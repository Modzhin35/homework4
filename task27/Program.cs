//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Method(int num)
{
    int result = 0;
    while (Math.Abs(num) > 0)
    {
        result++;
        num /= 10;
    }
    return result;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine($"В числе 0 содержится 1 цифра.");
else
{
    int res = Method(number);
    Console.WriteLine($"В числе {number} содержится {res} цифр.");
}