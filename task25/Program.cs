// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Метод, который возводит в степень:
int Func(int fNum, int sNum)
{
    int res = fNum;
    for (int i = 1; i < Math.Abs(sNum); i++) res = res * fNum;
    return res;
}

Console.WriteLine("Введите два числа:");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
if (secondNum==0) Console.WriteLine($"Число {firstNum} в степени 0 = 1.");//число в степени ноль = 1.
else Console.WriteLine($"Число {firstNum} в степени {secondNum} = {Func(firstNum, secondNum)}.");