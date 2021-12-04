// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".
string text = "Сосны обступали тропу плотно, и, хотя истыканное их верхушками небо светилось голубым, "
            + "в лесу было сумрачно. По тропинке вперёд бежали муравьи, большие, красные, по своим каким-то муравьиным делам."
            + "– Смотри, пап, им с нами по пути! – сказала Таня. – Наверное, они тоже на пляж собрались!";

// string s = "ffkgjg"
//             012345
// s[3]=g (можно найти символ с заданным индексом)

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|'); //указываем что в тексте нужно заменить пробелы на черточки
Console.WriteLine(newText);// выведем преобразованный тект
Console.WriteLine();// разделим вывод каждого из заданий пустой строчкой

newText = Replace(newText, 'к', 'К');// теперь аргументом будет являться уже преобразованный текст(newText), и указываем через запятую второй ряд изменений
Console.WriteLine(newText);

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);