List<int> nPrimos = new List<int>() { 2, 3 };
Boolean ban;
int num = 2,count;

for (int i = 0; i < 100; i++)
{
    ban = true;
    while (ban)
    {
        count = 0;
        foreach (var item in nPrimos)
        {
            if (num % item == 0)
            {
                break;
            }
            count++;
        }
        if (count == nPrimos.Count)
        {
            nPrimos.Add(num);
            ban= false;
            break;
        }
        num++;
    }
}

for (int i = 0; i < nPrimos.Count; i++)
{
    Console.WriteLine($"Primo #{i+1}\t{nPrimos[i]}");
}

Console.ReadLine();