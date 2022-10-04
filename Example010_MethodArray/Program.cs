int[] array = { 1, 2, 3, 65, 4, 65, 46, 27, 18 };

int n = array.Length;
int find = 65;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}