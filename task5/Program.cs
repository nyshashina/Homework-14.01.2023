// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA >= 100 && numberA <= 999){
    Console.WriteLine("Последняя цифра трехзначного числа " + numberA % 10);
}
else{
    Console.WriteLine("Это не трехзначное число.");
}