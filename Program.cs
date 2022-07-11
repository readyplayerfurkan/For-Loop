
Console.Write("Lütfen bir sayı giriniz: ");
int girilen = int.Parse(Console.ReadLine());

for (int i= 0; i <= girilen; i++)
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

int tekToplam = 0;
int ciftToplam = 0;

for (int i = 0; i <= 1000; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}

Console.WriteLine(ciftToplam);
Console.WriteLine(tekToplam);


for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.ReadLine();