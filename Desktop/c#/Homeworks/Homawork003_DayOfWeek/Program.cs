System.Console.WriteLine("Введите номер дня недели");
int NumDayOfWeek = Convert.ToInt32(Console.ReadLine());
if (NumDayOfWeek == 6 || NumDayOfWeek == 7)
{
    System.Console.WriteLine("да");
}
else if (NumDayOfWeek == 1 || NumDayOfWeek == 2 || NumDayOfWeek == 3 || NumDayOfWeek == 4 || NumDayOfWeek == 5)
{
       System.Console.WriteLine("нет");
}
else
{
    System.Console.WriteLine("такого дня недели не существует");
}