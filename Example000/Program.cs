Console.Clear();
Console.Write("Введите радиус: ");
int n = int.Parse(Console.ReadLine());
float p = 3.14F;
double s = (Math.Pow(n, 2) * p);
s = Math.Round(s, 0);
Console.WriteLine(s);
char [] array = s.ToString().ToCharArray();
int index = 0;
int indexMax = 0;
while (index < array.Length){
    if(array[index] > array[indexMax]){
        indexMax = index;}
        index++;
    
}
Console.Write(array[indexMax]);