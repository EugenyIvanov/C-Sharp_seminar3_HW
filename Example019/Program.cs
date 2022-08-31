Console.Clear();
Console.Write("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());

if (x < 10000 || x > 99999){
    Console.WriteLine("Введите пятизначное число!");
}

 else if(x % 10 == x / 10000 || x / 10 % 10 == x / 100 % 10){
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}
