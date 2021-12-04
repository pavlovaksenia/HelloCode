// Отсортировать последовательность чисел от минимального к максимальному
/*1. Найти позицию минимального элемента в неотсортированной части массива
2. Произвести обмен этого значения со значением первой неотсортированной позиции
3. Повторять пока есть неотсортированные элементы*/
int [] array = { 1, 5, 3, 7, 2, 9, 4, 3, 1 };// сначала заведем массив

void PrintArray(int[] array)//вывод данного массива на экран, в качестве аргумента будет приходить массив (array)
{
    int count = array.Length;//получение количества элементов
    for (int i = 0; i < count; i++)//пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} ");//и показываем их на экране
    }
    Console.WriteLine();//вывод путой строки
}
PrintArray(array);
//теперь напишем метод, который будет упорядочивать массив
void SelectionSort(int[] array)//в качестве аргумента - массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
     int minPosition = i;
    for (int j = i+1; j < array.Length; j++)//этот блок кода ищет минимальный элемент
    {
        if(array[j]<array[minPosition]) minPosition = j;
    }//тут он заканчивается
     int temporary = array[i];//и начинается перестановка от минимального к максимальному
     array [i] = array[minPosition];
     array[minPosition] = temporary;   
    }
} 
SelectionSort(array);
PrintArray(array);