# lesson_5
###  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
`Результат: [345, 897, 568, 234] -> 2 `
```csharp
void answer(int B){
    int[] arr = rnd_num(B); 
    int k = 0;
    foreach(int element in arr) if (element % 2 == 0) k++;
    Console.Write("[");
    for (int i = 0; i < B - 1; ++i) Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[B - 1] + "] -> Четных элементов: " + k);
}
int[] rnd_num(int A){
    int[] arr = new int[A];
    Random rnd = new Random();
    for (int i = 0; i < A; i++) arr[i] = rnd.Next(100, 999);
    return arr;
}
Console.WriteLine("Введите размер массива: ");
int B = Convert.ToInt32(Console.ReadLine());
answer(B);
```

------------


###  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
`Результат: [3, 7, 23, 12] -> 19`

```csharp
void answer(int B){
    int[] arr = rnd_num(B); 
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) if (i % 2 != 0) sum = sum + arr[i];
    Console.Write("[");
    for (int i = 0; i < B - 1; ++i) Console.Write(arr[i] + ", ");
    Console.WriteLine($"{arr[B - 1]}] -> {sum}");
}
int[] rnd_num(int A){
    int[] arr = new int[A];
    Random rnd = new Random();
    for (int i = 0; i < A; i++) arr[i] = rnd.Next(-100, 100);
    return arr;
}
Console.WriteLine("Введите размер массива: ");
int B = Convert.ToInt32(Console.ReadLine());
//запускаем главную функцию
answer(B);
```

------------


### Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

`Результат: [3 7 22 2 78] -> 76`
```csharp

void answer(int B){
    int  i = 0;
    double[] arr = rnd_num_d(B);
    var min = arr[0];
    var max = arr[0];
    var minIndex = 0;
    var maxIndex = 0;
    for (i = 0; i < B; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
        else if (arr[i] > max)
        {
            max = arr[i];
            maxIndex = i;
        }
}
    Console.Write("[");
    for (int x = 0; x < B - 1; ++x) Console.Write(arr[x] + " ");
    Console.WriteLine($"{arr[B - 1]}] -> {max-min}");
}
double[] rnd_num_d(int A){
    double[] arr = new double[A];
    Random rnd = new Random();
    for (int i = 0; i < A; i++) arr[i] = rnd.Next(-100, 100);
    return arr;
}
Console.WriteLine("Введите размер массива: ");
int B = Convert.ToInt32(Console.ReadLine());
answer(B);
```
