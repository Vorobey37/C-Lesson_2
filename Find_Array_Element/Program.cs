int[]array={1, 23, 32, 59, 68, 8, 9, 15};
int n = array.Length;
int find = 9;
int index = 0;
while (index<n)
{
if (array[index] == find)
{Console.WriteLine(index);
return;}

    index++;
}
Console.WriteLine("Не нашел(((");


