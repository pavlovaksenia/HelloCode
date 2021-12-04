// void - ничего не возвращающий метод (не нужно писать return)
void FillArray(int[] collection) //Эта функция придумывает массив не с нулями)))
{
    int lenght = collection.Length; //определяет длину массива
    int index = 0;
    while (index<lenght)
    {
        collection[index] = new Random().Next(1, 10); //положить новое случайное число из диапозона 1-10 
        index++; //index = index + 1;
    } 
}

void PrintArray(int[] col) //col=collection Эта функция выводит массив на экран
{
    int count = col.Length;
    int position = 0; //position=index
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;  
    } 
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =-1;//если для поиска будет заявлено число которого нет в масиве, то появится -1, если есть чтсло - оно появится на экране
    while (index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //останавливается на первом подходящем числе и не идет дальше, без него будут отображаться все индексы подходящих чисел
        }
        index ++;
    } 
    return position;
}

int[] array = new int[10]; //"создай новый массив в котором будет 10 элементов"

FillArray(array); //заполнил массив
PrintArray(array); //распечатал массив
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos); 

