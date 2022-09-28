// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int total = 0;

Console.WriteLine($"{number} -> {Sum(total)}");

  int Sum(int step)
  {
    int counter = Convert.ToString(number).Length;
    int buff = 0;
    int total = 0;

    for (int i = 0; i <= counter; i++)
    {
      buff = number - number % 10;
      total = total + (number - buff);
      number = number / 10;
    }
   return total;
  }