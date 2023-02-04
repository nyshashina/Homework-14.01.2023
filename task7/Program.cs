// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число из отрезка [10, 99]");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA >= 10 && numberA <= 99){
    if(numberA / 10 > numberA % 10){
        Console.WriteLine("Наибольшая цифра числа "+ numberA + " это " + numberA / 10);
    }
    else{
        Console.WriteLine("Наибольшая цифра числа "+ numberA + " это " + numberA % 10);
    }
}
else{
    Console.WriteLine("Это число не входит в отрезок [10, 99].");
}
