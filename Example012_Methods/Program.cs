// Вид 1 метод, который ничего не принимает и ничего не отдаёт
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); //так вызывается такой метод //не забывать про скобки при вызове такого метода

// Вид 2 метод, которые ничего не возвращают, но принимают аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("текст", 4);                   //аргументы пишутся либо в том порядке в котором стоят в методе
Method21(count: 2, msg: "Новый текст"); //либо в любом порядке, если они обозначены вот таким образом

// Вид 3 метод, который что-то возвращает, но ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year - 30);
/*  Console.WriteLine(Method3); - так не работает   */
// Вид 4 метод, который что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
/*{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}*/


string res = Method4(3, "asdf  ");
Console.WriteLine(res);
