// Программа принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число, чтобы выяснить, является ли оно палиндромом: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Введённое число: {number} является палиндром.");
  }
  else Console.WriteLine($"Введённое число: {number} не является палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Ошибка ввода. Введите пятизначное число.");