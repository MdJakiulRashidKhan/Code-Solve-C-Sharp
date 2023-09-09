var line = Console.ReadLine();
var data = line.Split(' ');
var k = int.Parse(data[0]); 
var n = int.Parse(data[1]);
var w = int.Parse(data[2]);

int sum = 0;




for (int i = 1; i <=w; i++)

{
 
    sum += i;

}

int d = (sum * k) - n;
if (d < 0)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine(d);
}