// напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int sum = 0;
Char [] a = n.ToCharArray(); // Преобразовали в массив
for (int i = 0; i < n.Length; i++)
{
int b = Convert.ToInt32(n[i] - '0');   
sum = sum + b;
} 
Console.WriteLine(sum);
