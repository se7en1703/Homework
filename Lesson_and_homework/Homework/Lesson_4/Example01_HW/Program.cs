Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string strA = Convert.ToString(a);
int z = 0;
for(int i = 0; i < strA.Length; i++)
    z = z + int.Parse(strA[i].ToString());
Console.WriteLine(z);