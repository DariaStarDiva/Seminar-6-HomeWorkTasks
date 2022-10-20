// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Сколько чисел будете вводить: ");
int a = Convert.ToInt32(Console.ReadLine());
int CountP = 0;

 for (int i = 0; i <a; i++)
 {
    Console.Write("Введите числа : ");
    int m = Convert.ToInt32(Console.ReadLine());
    
       if (m > 0)
         CountP++; 
   }
  
Console.WriteLine( $" Количество положительных чисел = {CountP}");