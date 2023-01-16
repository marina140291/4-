// Напишите цикл, который принимает на вход два числа (А и В) 
//и возводит число А в натуральную степень В.

Console.WriteLine ( "Введите число A: " );
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ( "Введите число B: " );
double B = Convert.ToDouble(Console.ReadLine());

double N = Math.Pow(A, B);
Console.Write(N);

