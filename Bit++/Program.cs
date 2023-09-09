int num = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; i < num; i++)

{
    string value = Console.ReadLine();

    if (value[0] == '-' || value[2] == '-')

    {
        result -= 1;
    }

    else if (value[0] == '+' || value[2] == '+')

    {
        result += 1;
    }
}
Console.WriteLine(result);