// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine() ?? "0");

if (day > 0 && day <= 7)
{
    if (day == 1){
        Console.WriteLine(day + " день недели - понедельник");
    }
    if (day == 2){
        Console.WriteLine(day + " день недели - вторник");
    }
    if (day == 3){
        Console.WriteLine(day + " день недели - среда");
    }
    if (day == 4){
        Console.WriteLine(day + " день недели - понедельник");
    }
    if (day == 1){
        Console.WriteLine(day + " день недели - четверг");
    }
    if (day == 5){
        Console.WriteLine(day + " день недели - пятница");
    }
    if (day == 6){
        Console.WriteLine(day + " день недели - суббота");
    }
    if (day == 7){
        Console.WriteLine(day + " день недели - воскресенье");
    }
}
else{
    Console.WriteLine("В неделе 7 дней");
}