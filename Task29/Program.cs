// Напишите программу, которая задаёт массив
//  из 8 элементов и выводит их на экран.

void ArAnyRange(int n, int a, int z) {
    int[] ar = new int[n];
    for (int i = 0; i < n; i++) {
        ar[i] = new Random().Next(a, z);}
    Console.WriteLine($"Массив из {n} случайных элементов " +
        $"в диапазоне от {a} до {z}: [{String.Join(", ", ar)}]");}
    
    Console.Clear();
    ArAnyRange(8, 4258, 5879);
    ArAnyRange(20, -400, 0);
    ArAnyRange(12, 0, 400);