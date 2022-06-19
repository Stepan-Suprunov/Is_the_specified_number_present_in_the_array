// Присутствует ли заданное число в массиве

Console.WriteLine("Введите число для поиска");
int user = int.Parse(Console.ReadLine());

int [] array = new int [30];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Scan()
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == user)
    {
        Console.WriteLine("Присутствует");
        break;
    }
    else if (i == array.Length -1)
    {
        Console.WriteLine("Отсутствует");
    }
}
}

PrintArray(array);
Console.WriteLine();
Scan();
