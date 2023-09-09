string inputWord = Console.ReadLine();

int inputLength = inputWord.Length;

int count = 0;

char[] array = new char[inputLength];

for (int i = 0; i < inputWord.Length; i++)

{
    array[i] = inputWord[i];
}

Array.Sort<char>(array);

for (int j = 1; j < inputLength; j++)

{
    if (array[j] != array[j - 1])
    {
        count++;
    }
}

if ((count + 1) % 2 == 0)

{
    Console.WriteLine("CHAT WITH HER!");
}

else

{
    Console.WriteLine("IGNORE HIM!");
}
