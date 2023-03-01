Console.Write("Введите три числа: ");
int FirstNumber = Console.Read();
Console.Write(", ");
int SecondNumber = Console.Read();
Console.Write(", ");
int ThirdNumber = Console.Read();
Console.WriteLine(".");

if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber) // Первое наибольшее
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(FirstNumber);
}
else if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber) // Второе наибольшее
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(SecondNumber);
}
else if (SecondNumber == FirstNumber && SecondNumber == ThirdNumber) // Равны
{
   Console.WriteLine("Числа равны!");
}
else // Третье наибольшее
{
    Console.Write("Наибольшее число: "); 
    Console.WriteLine(ThirdNumber);
}