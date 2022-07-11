Console.WriteLine("Введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " большее");
}
else if (num1 == num2)
{
    Console.WriteLine("Число " + num1 + " равно числу " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " большее");
}
