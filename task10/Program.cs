// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA >= 100){
    int num = numberA;
    int secondA = 0;
    int secondnum = 0;
    while (num >= 100){
        secondnum = num % 10;
        secondA = (secondA + secondnum) * 10;
        num = num / 10;
    }
    secondA = secondA / 10;
    Console.WriteLine("Третья цифра числа это " + secondA % 10);
}
else{
    Console.WriteLine("Третьей цифры числа нет");
}