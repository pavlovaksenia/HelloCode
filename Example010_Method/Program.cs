//ищем какой индекс у заданного числа
int[] array = {1,2,3,4,8,5,6,7,8};

int n = array.Length; //определяет длину массива
int find = 8;

int index = 0;

while(index<n)
{
if (array[index]==find)
{
    Console.WriteLine (index);
    break;
}
    index++; //index = index+1;
}