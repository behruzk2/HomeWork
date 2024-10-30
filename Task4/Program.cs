Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++){
    if (i % 2 == 1)
    {
       Console.WriteLine(i + " ");
    }
}
