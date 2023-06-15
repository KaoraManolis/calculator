// калькулятор написала)) но правда деление только на целое делит, я так понимаю тип Double надо было использовать 

Console.WriteLine("input number =>");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("выбери знак");
char oper = Convert.ToChar(Console.ReadLine());

Console.WriteLine("input number =>");
int B = Convert.ToInt32(Console.ReadLine());
int total = 0;

if (oper == '*')
{
total = A * B;
}

if (oper == '+')
{
total = A + B;
}

if (oper == '/')
{
total = A / B;
}

if (oper == '-')
{
total = A - B;
}
Console.WriteLine("полученный результат");
Console.WriteLine(total);