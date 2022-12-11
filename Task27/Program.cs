// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе

long SumDigNum(long num) {
    long sum = 0; 
    long temp = 0;
    if (num > 0) temp = num;
    if (num < 0) temp = num * -1;
    for (int i = 0; temp >= 1; i++) {
        sum = sum + temp % 10;
        temp = temp / 10;}
    Console.Write($"Сумма цифр числа {num} - ");
    return sum;}

Console.Clear();
Console.WriteLine(SumDigNum(25814764));
Console.WriteLine(SumDigNum(-58246579));
Console.WriteLine(SumDigNum(9876543210));