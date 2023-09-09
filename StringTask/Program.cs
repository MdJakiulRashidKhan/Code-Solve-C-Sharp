string word = Console.ReadLine();

int l = word.Length;

string s = word.ToLower();

int c = 0;

for (int m = 0; m < l; m++)

{
    if (s[m] != 'a' && s[m] != 'e' && s[m] != 'i' && s[m] != 'o' && s[m] != 'u' && s[m] != 'y')

    {
        c++;
    }
}

Console.Write(".");

int d = 0;

for (int n = 0; n < l; n++)

{
    if (s[n] != 'a' && s[n] != 'e' && s[n] != 'i' && s[n] != 'o' && s[n] != 'u' && s[n] != 'y' && d != c - 1)
    {
        Console.Write(s[n] + ".");
        d++;
    }
    else if (s[n] != 'a' && s[n] != 'e' && s[n] != 'i' && s[n] != 'o' && s[n] != 'u' && s[n] != 'y' && d == c - 1)
    {
        Console.WriteLine(s[n]);
    }
}
