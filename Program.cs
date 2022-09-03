// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void answer(int B){
    int[] arr = rnd_num(B); 
    int k = 0;
    foreach(int element in arr) if (element % 2 == 0) k++;
    Console.Write("[");
    for (int i = 0; i < B - 1; ++i) Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[B - 1] + "] -> Четных элементов: " + k);
}
//функция создает массив и возвращает ёё
int[] rnd_num(int A){
    int[] arr = new int[A];
    Random rnd = new Random();
    for (int i = 0; i < A; i++) arr[i] = rnd.Next(100, 999);
    return arr;
}
//отправляем запрос на размер массива
Console.WriteLine("Введите размер массива: ");
int B = Convert.ToInt32(Console.ReadLine());
//запускаем главную функцию
answer(B);