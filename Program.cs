/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
456 -> 5
782 -> 8
918 -> 1 */
/* int Pront (stringe messege)
{
    System.Console.Write(messege);
    string value = Controle.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("А-та-та, это не трехзначное число");
    return;
}
Console.WrightLine($"Введите число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`"); */

/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* int Prompt(string messege)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
} */

/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет */
int Prompt(string message)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekkend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("А ты хорош");
    return false;
}

int weekDay = Prompt("Введите день недели >");
if(ValidateWeekday(weekDay))
{
    if(IsWeekkend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной, учимся!");
    }
    else
    {
        Console.WriteLine("Ну, просто на работу");
    }
} 