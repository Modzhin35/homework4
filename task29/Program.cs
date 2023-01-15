// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void ContPrintArr (int length){
    int [] arr = new int [Math.Abs(length)];
    for(int i=0; i<Math.Abs(length); i++) arr[i]=new Random().Next(-99, 99);
    for (int j=0; j<Math.Abs(length); j++) Console.Write($"{arr[j]} ");
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ContPrintArr(size);