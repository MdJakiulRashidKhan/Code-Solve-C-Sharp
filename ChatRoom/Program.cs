string s = Console.ReadLine();

int charIndex = 0;
foreach (char i in s)
{
    if (i == 'h' && charIndex == 0)
    {
        charIndex = 1;
    }
    else if (i == 'e' && charIndex == 1)
    {
        charIndex = 2;
    }
    else if (i == 'l' && charIndex >= 2 && charIndex <= 3)
    {
        charIndex++;
    }
    else if (i == 'o' && charIndex == 4)
    {
        Console.WriteLine("YES");
        return;
    }
}

Console.WriteLine("NO");