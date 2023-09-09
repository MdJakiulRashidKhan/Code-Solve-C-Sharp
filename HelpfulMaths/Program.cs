string s = Console.ReadLine();
s.ToLower();
string[] num = s.Split('+');
num.ToArray();
Array.Sort(num);
Console.WriteLine(string.Join("+",num));