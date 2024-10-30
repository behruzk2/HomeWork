//Напишите метод, который на вход принимает два целых числа и проверяет,
//делится ли первое число на второе. Если делится, выводите "делится", иначе
//выводите "не делится".

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 == 0)
{
    Console.WriteLine("На 0 делить нельзя");
}
else if (num1 % num2 == 0)
{
    Console.WriteLine("делится");
}
else
{
    Console.WriteLine("не делится");
}