/*
Задача 19. Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Палиндром, перевертень — число, буквосочетание, слово или текст, 
одинаково читающееся в обоих направлениях.
*/

int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;
   while (!isCorrect)
   {
      Console.WriteLine(message);

      if (int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result <= 99999)
      {
         isCorrect = true;
      }
      else
      {
         Console.WriteLine("Введите корректное число");
      }
   }
   return result;
}

int number = GetNumber("Введите пятизначное число");

string numbers = number.ToString();
char[] numRev = numbers.ToCharArray();
Array.Reverse(numRev);
string newnumber = new String(numRev);

if (numbers == newnumber)
   Console.WriteLine($"число {number} палиндром");
else
   Console.WriteLine("число не палиндром");
