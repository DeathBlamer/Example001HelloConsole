int[] array = { 12, 213, 23, 54, 546, 602, 12, 98 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}