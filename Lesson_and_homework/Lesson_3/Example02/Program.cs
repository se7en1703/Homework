Console.Clear();
void Funct1(int[] collect)
{
    int len = collect.Length;
    int index = 0;
    while(index < len)
    {
        collect[index] = new Random().Next(1, 10);
        index++;
    }
}
void Funct2(int[] coll)
{
    int len2 = coll.Length;
    int index2 = 0;
    while(index2 < len2)
    {
    Console.WriteLine(coll[index2]);
    index2++;
    }
}
int Funct3(int[] collect, int x)
{
    int len3 = collect.Length;
    int index = 0;
    int position = 0;
    while(index < len3)
    {
        if(collect[index] == x)
            {
            position = index;
            break;
            }
        index++;
    }
    return position;
}
int[] array = new int[5];
Funct1(array);
Funct2(array);
Console.WriteLine();
int pos = Funct3(array, 4);
Console.WriteLine(pos);