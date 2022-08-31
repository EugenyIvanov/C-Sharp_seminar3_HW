Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int index = 1;
while(index <= x)
{
    Console.Write(Math.Pow(index, 3) + " ");
    index++;
}
while(index >= x)
{
    Console.Write(Math.Pow(index, 3) + " ");
    index--;
}