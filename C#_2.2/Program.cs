int [] array = {11,21,31,41,91,616,71,81,91}; // массив

int n = array.Length; // возвращает длину (количество) элементов массива
int find = 91;

int index = 0;

while (index < n)
{
    
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // в случае выполнения условия, прервется выполнение
    }
    // index = index + 1;
    index++;
}