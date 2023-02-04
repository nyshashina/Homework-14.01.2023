// Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Четные числа от 1 до " + numberN + ":");
for (int i = 2; i <= numberN; i++){
    if(i % 2 == 0){
        Console.Write(i + " ");
    }
}