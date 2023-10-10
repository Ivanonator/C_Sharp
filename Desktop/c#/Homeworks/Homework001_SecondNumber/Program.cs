System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 100;
int SecondNumber = ostatok / 10;
System.Console.WriteLine(SecondNumber);