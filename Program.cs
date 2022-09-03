// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
