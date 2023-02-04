// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA >= 100 && numberA <= 999){
    int secondA = numberA / 10;
    Console.WriteLine("Вторая цифра трехзначного числа " + secondA % 10);
}
else{
    Console.WriteLine("Это не трехзначное число.");
}
