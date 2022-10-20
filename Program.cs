// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество раз: ");
int count = 1;

while(count <= num)
{
    if (count == num)
        Console.Write($"{count*count}");
    else
        Console.Write($"{count*count}, ");
    count++;
}
