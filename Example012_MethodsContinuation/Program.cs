// Вид 1. Ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();//вызов метода


//Вид 2. Ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg) //void-ключевое слово, Method2 - идентификатор, string msg - к-то кол-во аргументов
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
//или второй вариан с указание количества
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);


//Вид 3. Что-то возвращают, но ничего не принимают

int Method3() //обязательно указывать тип данных
{
    return DateTime.Now.Year;
}
int year=Method3();
Console.WriteLine(year);


//Вид 4. Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    //int i =0;
    string result = string.Empty;
    for (int i =0; i<count; i++)// закоментированные строки заменяет цикл for
    //while (i<count)
    {
        result = result + text;
     //   i++;
    }
    return result;
}
string res = Method4(10,"sdfj"); //данный метод покажет 10 раз подряд текст в скобках
Console.WriteLine(res);
