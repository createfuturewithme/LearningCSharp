Console.WriteLine("Merhaba Dünya Bu Benim İlk Kodum.");

//--- Temel Tipler :
int yas = 25; // Tam sayı
double boy = 1.82; // Ondalıklı sayı
decimal fiyat = 99.90m; // Para hesapları için, Sonuna m gelir.
bool aktifMi = true; // True/False
char harf = 'A'; // Tek harf, Tek tırnak.
string isim = "Ali"; // Metin, Çift tırnak.


// var : Derleyici tipini sağ taraftan çıkartır. halen statik tiplidir.
var sayi = 10; // var Burada int değişkenini almıştır.
var ad = "String"; // var Burada string değişkenini almıştır.

// String interpolation :
Console.WriteLine($"{isim} {yas} yaşında.");

// Kullanıcıdan girdi alma ve dönüştürme :
Console.Write("Yaşın: ");
string giris = Console.ReadLine();
int yas2 = int.Parse(giris);

// Önemli Noktalar! :
// C# Büyük küçük harflere duyarlıdır. name ve Name farklı olur.
// Her ifade ; ile biter.
// Tipler arası dönüşüm: int.Parse(); , Convert.ToInt32(); , Güvenli yol: int.TryParse(); .

// Alıştırma : 
// 1. kullanıcıdan adını ve doğum yılını al.
// 2. yaşını hesapla.
// 3. Ekrana Merhaba (isim) 2026'da (yas) yaşındasın. Yazdır.

// Benim yaptığım:
Console.Write("Adınızı Giriniz: ");
string kulisim = Console.ReadLine();
Console.Write("Doğum Yılınızı Giriniz: ");
int kuldogumyil = int.Parse(Console.ReadLine());

int mevcutyil = DateTime.Now.Year;
int kulyas = mevcutyil - kuldogumyil;

Console.WriteLine($"Merhaba {kulisim}, {mevcutyil}'da {kulyas} Yaşındasın.");

//Claude'un Yaptığı:
Console.Write("Adınızı Giriniz: ");
string kulisim1 = Console.ReadLine();
Console.Write("Doğum Yılınızı Giriniz: ");
if (int.TryParse(Console.ReadLine(), out int kuldogumyil1))
{
    int mevcutyil1 = DateTime.Now.Year;
    int kulyas1 = mevcutyil - kuldogumyil;
    Console.WriteLine($"Merhaba {kulisim1}, {mevcutyil1}'da {kulyas1} Yaşındasın.");
}
else
{
    Console.WriteLine("Geçerli bir sayı girmedin.");
}

