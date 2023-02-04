// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA % 2 == 0){
    Console.WriteLine("Число " + numberA + " является четным");
}
else{
    Console.WriteLine("Число " + numberA + " не является четным");
}
