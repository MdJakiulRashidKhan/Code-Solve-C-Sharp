string firstString = Console.ReadLine();

string secondString = Console.ReadLine();

string a = firstString.ToLower();

string b = secondString.ToLower();

int i;

if (a == b)
{
    Console.WriteLine("0");
}
else
{
    for (i = 0; i < a.Length; i++)
    {
        if (a[i] < b[i])
        {
            Console.WriteLine("-1");
            break;
        }
        if (a[i] > b[i])
        {
            Console.WriteLine("1");
            break;
        }
    }
}