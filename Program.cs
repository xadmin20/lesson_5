// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void answer(int B){
    int[] arr = rnd_num(B); 
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) if (i % 2 != 0) sum = sum + arr[i];
    Console.Write("[");
    for (int i = 0; i < B - 1; ++i) Console.Write(arr[i] + ", ");
    Console.WriteLine($"{arr[B - 1]}] -> {sum}");
}
//функция создает массив и возвращает ёё
int[] rnd_num(int A){
    int[] arr = new int[A];
    Random rnd = new Random();
    for (int i = 0; i < A; i++) arr[i] = rnd.Next(-100, 100);
    return arr;
}
//отправляем запрос на размер массива
Console.WriteLine("Введите размер массива: ");
int B = Convert.ToInt32(Console.ReadLine());
//запускаем главную функцию
answer(B);
            