var number = Console.ReadLine();
var data = number.Split(' ');
var a = int.Parse(data[0]);
var n = int.Parse(data[1]);

for (int i =0;i<n;i++)
{
    if(a%10==0)
    {
        a /= 10;
    }
    else
    {
        a--;
    }
}
Console.WriteLine(a);