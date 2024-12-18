Console.WriteLine("Lütfen bir sayı giriniz");

int sayi = int.Parse(Console.ReadLine());

if(sayi > 10)
{
    Console.WriteLine("Bu sayı 6'dan büyüktür.");
    if(sayi % 2 == 0 )
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir.");
    }
}
else if ( sayi == 6)
{
    Console.WriteLine("Bu sayı 6'ya eşittir.");
}
else
{
    Console.WriteLine("Bu sayı 6'dan küçüktür.");
    if (sayi %2 == 0 )
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir.");
    }
}

Console.ReadLine();