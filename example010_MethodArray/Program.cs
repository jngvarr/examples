int[] array = { 1, 21, 13, 4, 81, 36, 27, 81, 79 };

int n = array.Length;

int find = 81;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}