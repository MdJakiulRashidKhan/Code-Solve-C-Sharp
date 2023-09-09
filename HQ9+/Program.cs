string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (s.Contains( 'H') || s.Contains('Q') || s.Contains('9'))
    {
        Console.WriteLine("YES");
        break;
    }
    else
    {
        Console.WriteLine("NO");
        break;
    }

}

