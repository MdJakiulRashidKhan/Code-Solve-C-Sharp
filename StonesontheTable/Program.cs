int n = Convert.ToInt32(Console.ReadLine());    
string a = Console.ReadLine();
int count = 0;
for(int i = 0; i < n-1;i++)
{
    if (a[i] == a[i+1])
    {
        count++;
    }
}
Console.WriteLine(count);