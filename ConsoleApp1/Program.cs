//Yeni akıllı saatler olmadan günlük koşu mesafemizi ölçebilir miyiz? Sizden günlük koşu 
//mesafemizi ölçen bir yazılım yapmanızı istiyorum. Yapacağınız yazılıma; sizin adım 
//boyunuzu, bir dakikada kaç adım attığınızı ve toplam koşu sürenizi belirtiğinizde size 
//metre cinsinden toplam koşu mesafenizi söyleyecek.
//Yapacağınız çözümü modüllere bölmeyi unutmayın. 
//Veriyi 4 adımda alacağız:
//1.Ortalama bir adımınızın kaç santimetre olduğunu gireceksiniz
//2.   Bir dakikada kaç adım koştuğunuzu gireceksiniz.
//3.   Koşu süresini 
//3.1. Önce saat 
//3.2. Ve dakika olarak gireceksiniz. 
//Lütfen her adımda verilerin doğruluğunu kontrol etmeyi unutmayın.
#region ALGORITMA:
/*
 * 1-BAŞLA
 * 2-DEGISKENLERI TANIMLA (short adimUzunlugu, dakikadaAdim, kosuSuresiSaat, kosuSuresiDakika, int kosuMesafesi)
 * 3-GİRİLEN HER DEĞER İÇİN TRY CATCH BLOKLARINI OLUŞTUR
 * 4-ARİTMETİK HESAPLAMALARI METOTLARLA YAP
 * 5- OPSİYONEL : TUR SÜRELERİNİ SIRALA
 * 6-BİTİR
 */

#endregion

#region DEGISKENLER:
int kullaniciAdimUzunlugu = 0, kullaniciKosuSuresiSaat = 0, kullaniciKosuSuresiDakika = 0;
double kullaniciDakikadaAdim = 0, kosuMesafesi;
#endregion

#region METOTLAR:

/// <summary>
/// Bu metotta girilen süre, mesafe ve dakika başına adım ile koşu mesafesini hesaplar.
/// </summary>
/// <param name="adimUzunlugu">kullanıcıdan alınan 1 adımının uzunluğunun santimetre cinsinden değeri</param>
/// <param name="dakikadaAdim">kullanıcının 1 dakikada kaç adım attığı</param>
/// <param name="kosuSuresiSaat">kullanıcının saat cinsinden girdiği koşu süresi</param>
/// <param name="kosuSuresiDakika">kullanıcının dakika cinsinden girdiği koşu süresi</param>
/// <returns>kosu mesafesinin hesabı</returns>
static double MesafeHesaplama(int adimUzunlugu, double dakikadaAdim, int kosuSuresiSaat, int kosuSuresiDakika)
{
    double dakikadaKosuSuresi(int adimUzunluk, double dakikaAdim, int kosuDakika)
    {
        double dakikadaKosu = ((adimUzunluk / 100) * dakikaAdim * kosuDakika);
        return dakikadaKosu;
    }
    double mesafe = (dakikadaKosuSuresi(adimUzunlugu, dakikadaAdim, kosuSuresiDakika)) + (dakikadaKosuSuresi(adimUzunlugu, dakikadaAdim, kosuSuresiSaat * 60));

    return mesafe;
}
#endregion

#region KODLAR , HATA YÖNETİMİ VE HESAPLAMALAR :

giris:
girisAdimUzunlugu:
try
{
    Console.Write("Koşarken 1 adımda ne kadar yol adığınızı santimetre cinsinden giriniz : ");
    kullaniciAdimUzunlugu = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Lütfen santimetre cinsinden bir sayı giriniz.");
}
if (kullaniciAdimUzunlugu <= 0)
{
    Console.WriteLine("Adım Uzunluğunuz sıfır ya da Negatif Sayı Olamaz.");
    goto girisAdimUzunlugu;
}
else goto girisDakikadaAdim;


girisDakikadaAdim:
try
{
    Console.Write("Koşarken 1 dakikada kaç adım attığınızı giriniz : ");
    kullaniciDakikadaAdim = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Lütfen reel sayı tipinde bir değer giriniz. Ondalıklı sayı girebilirsiniz");
}

if (kullaniciDakikadaAdim <= 0)
{
    Console.WriteLine("Dakikada attığınız adım sayısı sıfır ya da Negatif Sayı Olamaz.");
    goto girisDakikadaAdim;
}
else goto girisSaat;


girisSaat: try
{
    Console.Write("Koştuğunuz süreyi giriniz.\nSüre kısmının önce saatini sonra dakikasını giriniz.\nKaç saat koştuğunuzu giriniz : ");
    kullaniciKosuSuresiSaat = Convert.ToInt32(Console.ReadLine());

}
catch (FormatException)
{
    Console.WriteLine("Lütfen saat cinsinden bir sayı giriniz.");
}
if (kullaniciKosuSuresiSaat < 0)
{
    Console.WriteLine("Saat değeri Negatif Sayı Olamaz.");
    goto girisSaat;
}
else goto girisDakika;


girisDakika:
try
{
    Console.Write("Kaç dakika koştuğunuzu giriniz : ");
    kullaniciKosuSuresiDakika = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Lütfen dakika cinsinden bir sayı giriniz.");
}
if (kullaniciKosuSuresiDakika < 0)
{
    Console.WriteLine("Dakika değeri Negatif Sayı Olamaz.");
    goto girisDakika;
}
else goto hesaplama;


hesaplama:
kosuMesafesi = MesafeHesaplama(kullaniciAdimUzunlugu, kullaniciDakikadaAdim, kullaniciKosuSuresiSaat, kullaniciKosuSuresiDakika);

Console.WriteLine($"\n\nToplam Kosu Mesafeniz : {kosuMesafesi} metredir\n\n");

Console.WriteLine("Yeni Hesap Yapmak İster misiniz?\nÇıkış İçin 'exit' Yazın.\nDevam Etmek için 'enter' Tuşuna Basın : ");
string cikmakIstiyorMu = Console.ReadLine();
if (cikmakIstiyorMu == "exit")
    goto cikis;
else goto giris;

cikis: Console.ReadLine();

#endregion

