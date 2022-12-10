// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

double NumNatPow (double a, int b) {
    double res = 1;
    for (int i = 1; i <= b; i++) {
        res = a * res;}
    return res;}

Console.Clear();
Console.WriteLine(NumNatPow(5, 4));
Console.WriteLine(NumNatPow(7.5, 3));
Console.WriteLine(NumNatPow(5, 0));
Console.WriteLine(NumNatPow(-4.27, 7));