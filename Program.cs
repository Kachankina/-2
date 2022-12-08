//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int amount = number.ToString().Length;
// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     int number1 = ((number % 100) / 10);
//     Console.WriteLine($"Вторая цифра: {number1}");
// }


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine()!);
// if (num < 100)
// {
//    Console.WriteLine("Этой цифры нет");
// }
// else{
//          while (num >=1000)  
//          {
//             num = num / 10;
//          } 
//          int thirdNumber = num % 10;
//          Console.WriteLine($"Третья цифра {thirdNumber}");
//    }
//   
//     
    


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.WriteLine ("Введите день недели...");
// int dayofweek = int.Parse (Console.ReadLine()!);
//     if (dayofweek == 6 || dayofweek == 7)
//      {
//         Console.WriteLine ("Ответ: Выходной день.");
//      } 
//     else 
//         if (dayofweek <= 5)
//         {
//             Console.WriteLine ("Ответ: Будний день.");
//         } 
      
      
//     else 
//         if (dayofweek > 7)
//         {
//            Console.WriteLine ("Ошибка: В неделе всего 7 дней!"); 
//         } 
      
      