string str = Console.ReadLine();
int dangerous = 0;
int one = 0, zero = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == '1')
    {
        one++;
        zero = 0;
    }
    else
    {
        zero++;
        one = 0;
    }
    if (one == 7 || zero == 7)
    {
        dangerous = 1;
        break;
    }
}
if (dangerous == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}