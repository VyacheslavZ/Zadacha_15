Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день Выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Не корректый ввод");
  }
  else Console.WriteLine("Этот день Рабочий");
}

CheckingTheDayOfTheWeek(dayNumber);