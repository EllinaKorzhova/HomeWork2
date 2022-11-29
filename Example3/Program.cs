/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Введите день недели");
string numberOfTheDayStr = Console.ReadLine();
int numberOfTheDay = int.Parse(numberOfTheDayStr);

switch (numberOfTheDay) {
    case 1:
        Console.WriteLine("Это не выходной");
        break;
    case 2:
        Console.WriteLine("Это не выходной");
        break;
    case 3:
        Console.WriteLine("Это не выходной");
        break;
    case 4:
        Console.WriteLine("Это не выходной");
        break;
    case 5:
        Console.WriteLine("Это не выходной");
        break;  
    case 6:
        Console.WriteLine("Это выходной");
        break;
     case 7:
        Console.WriteLine("Это выходной");
        break;
    default:
        Console.WriteLine("Введите число от 1 до 7");
        break;
}