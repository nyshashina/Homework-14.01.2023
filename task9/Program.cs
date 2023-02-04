// Выяснить, кратно ли число заданному, если нет, вывести остаток.Console.WriteLine("Введите трехзначное число");
Console.WriteLine("Введите делимое");
int numberA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите делитель");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if(numberA % numberB == 0){
    int firstA = numberA / 100;
    int thirdA = numberA % 10;
    int xA = firstA * 10 + thirdA;
    Console.WriteLine(numberA + " кратно " + numberB);
}
else{
    Console.WriteLine("Остаток от деления равен " + numberA % numberB);
}