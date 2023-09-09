string s = Console.ReadLine();
int upper = 0;
int lower = 0;

for (int i = 0; i < s.Length; i++)
{
    if (char.IsUpper(s[i]))
    {
        upper++;
    }
    else
    {
        lower++;
    }
}

if (upper > lower)
{
    Console.WriteLine(s.ToUpper());
}
else
{
    Console.WriteLine(s.ToLower());
}