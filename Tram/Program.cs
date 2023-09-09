int num = Convert.ToInt32(Console.ReadLine());

int sum =0;
int min = 0;

for(int i = 0; i < num;i++)
{
    var passenger = Console.ReadLine();
    var data = passenger.Split(' ');
    var a = int.Parse(data[0]);
    var b = int.Parse(data[1]);

    sum = (a + min) - b;
    if(sum<0)
    {
        min = 0;
    }
    else
    {
        min= sum;
    }
}
Console.WriteLine(sum);