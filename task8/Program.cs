// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA >= 100 && numberA <= 999){
    int firstA = numberA / 100;
    int thirdA = numberA % 10;
    int xA = firstA * 10 + thirdA;
    Console.WriteLine("Если удалить вторую цифру трёхзначного числа " + numberA + ", получится " + xA);
}
else{
    Console.WriteLine("Это не трехзначное число.");
}
