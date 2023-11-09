using System.Diagnostics.Metrics;
Console.Write("Metin Giriniz: ");
string metin = Console.ReadLine();
string sonuc = null;
string[] dizi = metin.Split(' ');
foreach (string item in dizi)
    sonuc = sonuc + item + ' ';
Console.WriteLine(sonuc);