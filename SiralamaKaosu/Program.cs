string[] adlar = { "melis", "ilayda", "ezgi", "burak", "mehmet ali" };
int[] yaslar = { 23, 20, 27, 22, 28 };

Array.Sort(adlar);

for (int i = 0; i < adlar.Length; i++)
{
    Console.WriteLine($"{adlar[i]} {yaslar[i]} yaşındadır.");
}

Console.ReadKey();