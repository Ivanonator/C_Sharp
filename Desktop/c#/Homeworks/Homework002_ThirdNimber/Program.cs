Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 99)
{
       while (Number > 99)
       {
        Number /= 10;
        System.Console.WriteLine(Number + " ");
       }
    System.Console.WriteLine(Number%10);
}
else 
{
    System.Console.WriteLine("Ошибка! ");
}