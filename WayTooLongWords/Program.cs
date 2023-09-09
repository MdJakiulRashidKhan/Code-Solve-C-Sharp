int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= n)
{
    string inputWord = Console.ReadLine();

    if (inputWord.Length <= 10)
    {
        Console.WriteLine(inputWord);
    }
    else
    {
        char firstWord = inputWord[0];
        string milddileLetter = Convert.ToString(inputWord.Length - 2);
        char lastWord = inputWord[inputWord.Length - 1];
        Console.WriteLine(firstWord + "" + milddileLetter + "" + lastWord);
    }

    i++;
}