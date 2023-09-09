
int[,] mat = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    string[] x = Console.ReadLine().Trim().Split(' ');
    for (int j = 0; j < 5; j++)
    {
        mat[i, j] = int.Parse(x[j]);
    }
}

int a = 0, b = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (mat[i, j] == 1)
        {
            a = i;
            b = j;
            break;
        }
    }
}

Console.WriteLine(Math.Abs(2 - a) + Math.Abs(2 - b));