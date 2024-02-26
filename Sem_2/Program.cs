// // Вычислить и сложить первую и третью цифру трёхзначного числа.

// int number = 453;
// int firstDigit = number / 100; // 453/100=4 первая цифра
// int thirdDigit = number % 10; // 453%10=3 третья цифра
// int result = firstDigit * 10 + thirdDigit; //4*10+3=43
// // $" Текст {result} Текст"
// Console.WriteLine($"В числе {number} => {result}");

// Напишите программу которая принимает  на вход и возводит вторую цифру этого числа в степень равную третьей цифре.
//    Пример 487=>8^7=2097152
// 1ая цифра: Сотни / 100; 2ая цифра: Десятки / 10 и % 10; 3я цифра: Еденицы % 10.

// int number = 947;
// int secondDigit = number / 10 % 10; // 947 / 10 % 10 (947 / 10 = 94 % 10 = 4)
// int thirdDigit = number % 10; //947 % 10 = 7
// int result = (int) Math.Pow ( secondDigit, thirdDigit);
// Console.WriteLine ($"{secondDigit} ^ {thirdDigit} = {result}");

// Программа которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.
//      Пример: 456 >= 4
//              7812 >= 8

// int number = 925; // (number / 100) % 10
// if (number >=100)
// {
//     int thirdDigitFromEnd = (number / 100) % 10;
//     Console.WriteLine ($" Третья цифра с конца: {thirdDigitFromEnd}");
// }
// else 
// {
//     Console.WriteLine ("Третьей цифры нет");
// }