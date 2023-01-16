
// напишите программу , котрая задает массив из 8 элементов, котрые вводит
// пользователь и выводит их на экран

Console.WriteLine ( "Введите первый элемент массива: " );
 double a1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ( "Введите второй элемент массива: " );
 double a2 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine ( "Введите третий элемент массива: " );
 double a3 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine ( "Введите четвертый элемент массива: " );
 double a4 = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine ( "Введите пятый элемент массива: " );
 double a5 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ( "Введите шестой элемент массива: " );
 double a6 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine ( "Введите седьмой элемент массива: " );
 double a7 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine ( "Введите восьмой элемент массива: " );
 double a8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"[{string.Join(",  ", a1, a2, a3, a4, a5, a6, a7, a8)}]");
