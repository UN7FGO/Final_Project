Console.Clear();
Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i}-й элемент массива : ");
    array[i] = Convert.ToString(Console.ReadLine());
}

Console.WriteLine($"Оригинальный массив: [ {string.Join(", ", array)} ]");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) count++;

if (count > 0)
{
    Console.WriteLine($"В оригинальном массиве, {count} элементов, длинной до трех символов.");
    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    Console.WriteLine($"Результирующий массив: [ {string.Join(", ", result)} ]");
}
else
{
    Console.WriteLine($"В оригинальном массиве нет элементов, длинной до трех символов.");
}