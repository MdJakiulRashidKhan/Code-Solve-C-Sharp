var weight = Console.ReadLine();
var data = weight.Split(' ');
var a = int.Parse(data[0]);
var b = int.Parse(data[1]);

int i;
for(i=1; ;i++)
{
    a *= 3;
    b *= 2;
    if(a>b) break;
}
Console.WriteLine(i);

