Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number / 1000 != 0)
    {
       while (Number / 1000 == 0)
       {
        int num = Number % 10;
       }
    }
else if (Number / 100 == 0)
{
System.Console.WriteLine("Третьей цифры нет!");
}
else 
{
    System.Console.WriteLine(Number/100);
}