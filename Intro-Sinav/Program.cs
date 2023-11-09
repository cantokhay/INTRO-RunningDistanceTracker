//Parametre olarak alacağı bir string ifade içerisindeki birden fazla boşluğu tek boşluk karakterine dönüştüren, ifadenin başındaki ve sonundaki boşluk karakterlerini tamamen silen FullTrim adlı bir metot geliştiriniz.

Console.Write("Yazı Giriniz :");
string girilenYazi = Console.ReadLine();
FullTrim(girilenYazi, out string fullTrimli);
string FullTrim(string boslukluYazi, out string trimliYazi)
{
    trimliYazi = boslukluYazi.Trim();
    while (trimliYazi.Contains("  "))
        trimliYazi = trimliYazi.Replace("  ", " ");
    return trimliYazi;
}
Console.WriteLine(fullTrimli);

//C# programlama dilini .NET Framework’ten bağımsız çalıştırabilir miyiz?
//(5 Puan)

//Evet çalıştırabiliriz. .NET Framework harici, .NET core ve diğer CLR destekleyen başka bir programlama aracında C# diliyle program hazırlayabiliriz.
//2
//Program akış kontrolü (Flow Control) nedir? C# programlama dilinde bunu hangi yapılarla sağlayabiliyoruz? 
//(5 Puan)

// Hazırlayacağımız programda mantıksal veya aritmetik koşulları birbirleriyle karşılaştırmak, diğerini tetiklettirmek, sürekli tekrar ettirmek gibi ihtiyaçlarımızda; if - else, switch - case, for, while, foreach , do - while gibi "FLOW CONTROL" mekanizmalarını kullanırız.
//3
//Parametre olarak alacağı bir string ifade içerisindeki birden fazla boşluğu tek boşluk karakterine dönüştüren, ifadenin başındaki ve sonundaki boşluk karakterlerini tamamen silen FullTrim adlı bir metot geliştiriniz.  
//(5 Puan)

//Yanıtınızı girin
//4
//System.Int32 ile int arasındaki farkı açıklayınız.
//(5 Puan)

//System.Int32 içerisinde metotları ve propertyleri barındıran ve içerisine değer alabilen struct library iken int ise yine aynı şekilde System namespace altında oluşturulan bir structtır ve zamanla daha kolay kod yazmamıza yarayan geliştirilmiş bir keyworddür.
//5
//Convert ve Cast işlemleri nedir? İkisi arasındaki benzerlikleri ve farklılıkları yazınız.
//(5 Puan)

//Her ikisi de veri tipi dönüşümü yapabileceğimiz yöntemler olmakla birlikte; Convert yöntemi ile implicit değer dönüşümü yaparken Casting yöntemi ile explicit bir değer dönüşümü yapılır. 
//Casting yönteminde dönüştürülecek değişkenin önünde parantez içinde dönüştürmek istediğimiz veri tipini belirtiriz. Eğer dönüşüm gerçekleşmezse veri kaybı olabileceğini göze alırız. Yani derleme zamanında derleyicinin hata mesajı göstermesini önleriz fakat debug zamanında belirttiğimiz değer dönüşümü gerçeklemezse programın çalışmayacağını da biliriz ve aslında bu yöntemi uygulayarak dönüşümün başarısını kendi mantığımızla garanti altına alırız.
//Öte yandan Convert yönteminde ise derleme zamanında IDE ortamında da denetlenebilen bir veri tipi dönüştürme yöntemidir. Yani, istediğimiz veri tipi dönüşümü gerçekleşemeyecek türden bir dönüşüm ise derleme zamanında da hata mesajı alırız.
//6
//Değer tipli ve Referans tipli kavramları ne anlama gelmektedir? Açıklayın.
//(5 Puan)

//Değer tipli değişkenlere int, double, char, bool, struct, enum gibi örnekler verebiliriz.
//Referans tipli değişkenlere ise string, class, delegete, ve array örnek olarak gösterilebilir.
//Değer tipli değişkenler RAM'de stack alanında depolanırken, referans tipli değişkenler RAM'de heap alanında depolanırlar.Heapteki verinin adresi yine stackte tutulur.Bu adrese "GetHashCode()" metodu ile ulaşabiliriz.Hazırladığımız program her debug zamanında heapteki verileri adresler ve program kapandığında bu adresi siler. Her program çalıştırmasında "GetHashCode()" metodu ile adres almak istediğimizde bu adresin yeri değişecektir.Değer tipli değişkenler referans tipli değişkenlere göre daha hızlı çalışırlar.
//7
//ref ve out anahtar kelimelerini açıklayın, ikisi arasındaki benzerlik ve farklılıkları yazın.
//(5 Puan)

//Metot hazırlarken değişkenleri metotta kullanmaya yarayan; ref ve out anahtar kelimeleri aynı işlemi yapar. ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur. ref ile bir tane değeri metottan geri istediğimiz durumda kullanıyoruz. out ile metodun birden fazla değer vermesini istediğimizde kullanıyoruz. ref ile metoda gönderdiğimiz değeri metot içinde değiştirmek zorunda değiliz fakat out ile metoda gönderdiğimiz değerin bir başlangıcı olmadığından dolayı metot içinde kullanıp değiştirmek zorundayız.
//8
//Metot imzası ve aşırı yükleme kavramlarını açıklayınız? İkisi arasında nasıl bir bağlantı vardır?
//(5 Puan)

//Metot aşırı yükleme aynı isme sahip birden fazla metodun olabilmesidir.Yani aynı metodu farklı değişken tipleri vererek ve/veya farklı işlemler yaptırarak kullanabiliriz.Metot imzası ise metodun ismi ve aldığı değişkenlerin tipleri ve değişkenlerin adedidir. Aşırı yükleme yapılmış metotlar aynı imzaya sahip olamazlar. Metot imzasına, metodun dönüş tipi dahil değildir.
