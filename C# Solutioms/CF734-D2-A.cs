var n = int.Parse(Console.ReadLine());
var f = Console.ReadLine();

int aTimes = 0;
int dTimes = 0;
for (int i = 0; i < n; i++)
{
    if (f[i] == 'A') { aTimes++; }
    else if (f[i] == 'D') { dTimes++; }
}
Console.WriteLine(aTimes == dTimes ? "Friendship" : aTimes > dTimes ? "Anton" : "Danik");