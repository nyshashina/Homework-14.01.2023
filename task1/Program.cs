// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if(numberB * numberB == numberA) {
    Console.WriteLine("Первое число является квадратом второго");
}
else {
    Console.WriteLine("Первое число не является квадратом второго");
}