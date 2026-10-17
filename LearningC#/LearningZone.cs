//Console.WriteLine("Merhaba Dünya Bu Benim İlk Kodum.");

////---Temel Tipler:
//int yas = 25; // Tam sayı
//double boy = 1.82; // Ondalıklı sayı
//decimal fiyat = 99.90m; // Para hesapları için, Sonuna m gelir.
//bool aktifMi = true; // True/False
//char harf = 'A'; // Tek harf, Tek tırnak.
//string isim = "Ali"; // Metin, Çift tırnak.


////--- var : Derleyici tipini sağ taraftan çıkartır. halen statik tiplidir.
//var sayi = 10; // var Burada int değişkenini almıştır.
//var ad = "String"; // var Burada string değişkenini almıştır.

////--- String interpolation :
//Console.WriteLine($"{isim} {yas} yaşında.");

////--- Kullanıcıdan girdi alma ve dönüştürme :
//Console.Write("Yaşın: ");
//string giris = Console.ReadLine();
//int yas2 = int.Parse(giris);

////--- Önemli Noktalar! :
//// C# Büyük küçük harflere duyarlıdır. name ve Name farklı olur.
//// Her ifade ; ile biter.
//// Tipler arası dönüşüm: int.Parse(); , Convert.ToInt32(); , Güvenli yol: int.TryParse(); .

////--- Alıştırma : 
//// 1. kullanıcıdan adını ve doğum yılını al.
//// 2. yaşını hesapla.
//// 3. Ekrana Merhaba (isim) 2026'da (yas) yaşındasın. Yazdır.

////--- Benim yaptığım:
//Console.Write("Adınızı Giriniz: ");
//string kulisim = Console.ReadLine();
//Console.Write("Doğum Yılınızı Giriniz: ");
//int kuldogumyil = int.Parse(Console.ReadLine());

//int mevcutyil = DateTime.Now.Year;
//int kulyas = mevcutyil - kuldogumyil;

//Console.WriteLine($"Merhaba {kulisim}, {mevcutyil}'da {kulyas} Yaşındasın.");

////---Claude'un Yaptığı:
//Console.Write("Adınızı Giriniz: ");
//string kulisim1 = Console.ReadLine();
//Console.Write("Doğum Yılınızı Giriniz: ");
//if (int.TryParse(Console.ReadLine(), out int kuldogumyil1))
//{
//    int mevcutyil1 = DateTime.Now.Year;
//    int kulyas1 = mevcutyil - kuldogumyil;
//    Console.WriteLine($"Merhaba {kulisim1}, {mevcutyil1}'da {kulyas1} Yaşındasın.");
//}
//else
//{
//    Console.WriteLine("Geçerli bir sayı girmedin.");
//}

//// ---1. Gün Tekrar---:
////Kullanıcıdan adını ve soyadını al.
////İkisini birleştirip Merhaba Ali Yılmaz! şeklinde yazdır.
////Bonus: Kullanıcıdan iki sayı al, toplamını ve çarpımını yazdır.

//Console.Write("İsminizi Girin: ");
//string isim = Console.ReadLine();
//Console.Write("Soy İsminizi Girin:");
//string soyİsim = Console.ReadLine();

//Console.WriteLine($"Merhaba {isim} {soyİsim}!");

//Console.Write("İlk Sayıyı Giriniz: ");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.Write("İkinci Sayıyı Giriniz: ");
//int sayi2 = int.Parse(Console.ReadLine());

//int toplam = sayi1 + sayi2;
//int carpim = sayi1 * sayi2;
//Console.WriteLine($"Sayıların Toplamı: {toplam}");
//Console.WriteLine($"Sayıların Çarpımı: {carpim}");


// ===== GÜN 2 =====

//--- 1. Koşul (if): Eğer şöyle ise şunu yap!
//Program normalde satır satır akar if ile doğruysa şunu çalıştır diyebiliriz.
//int yas = 20;
//if (yas >= 18)
//{
//    Console.WriteLine("Yetişkinsiniz");
//}
//--- if açıldıktan sonra bir karşılaştırma yaptık parantez içinde bu karşılaştırma true dönerse süslü parantez içine girer eğer false dönerse
//-- parantez içinden çıkar ve o kodu çalıştırmaz. Şimdi else kısmına gelelim.

//----------------------------ELSE-------------------------------------------------

//int yas = 20;
//if (yas >= 18)
//{
//    Console.WriteLine("Yetişkinsiniz");
//}
//else
//{
//    Console.WriteLine("Çocuksunuz.");
//}
//--- Burada değer true döndüğü için ilk süslü paranteze girecektir eğer false dönseydi else kısmına girecek ve ekrana "Çocuksunuz" Yazacaktı.

//--------------------------ELSE IF----------------------------------------------------

//--- Birden fazla ihtimal için(else if):

//int not = 75;

//if(not >= 85)
//{
//    Console.WriteLine("Pek İyi");
//}
//else if (not >= 70)
//{
//    Console.WriteLine("İyi");
//}
//else
//{
//    Console.WriteLine("Geliştirmen Lazım");
//}
//--- Yukarıdan aşağıya bakılır ilk doğru çıkan çalışır kalan atlanır.

//---------------------------------ŞARTLAR--------------------------------------------

//--- && ve ||: Birden fazla şart
//int yas = 25;
//bool ehliyetVarMi = true;

//if (yas >= 18 && ehliyetVarMi)
//{
//    Console.WriteLine("Araba Kullanabilirsin.");
//}
//- && ikiside doğru olmalı
//- || birinin doğru olması yeterlidir
//- ! değil : !ehliyetVarMi : Ehliyet yoksa

//------------------------------------DÖNGÜLER-------------------------------------------------

//---“Aynı işi tekrar tekrar yap”

//--- WHILE : koşul doğru olduğu sürece tekrarlar---

//int sayac = 1;

//while (sayac <= 5)
//{
//    Console.WriteLine($"Sayı: {sayac}");
//    sayac++;
//}
//-- sayaç her döngüde bir artar ve 6 olunca döngü biter çünkü değer false döner

//--- FOR : Kaç kere dönmesi gerektiğini biliyorsak.---

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Sayı: {i}");
//}
//-- Parantezin içi üç parça: Başlangıç;Koşul;Her turdan sonra ne olsun.
//-- Break döngüyü tamamen bitirir.
//-- Continue o turu atlayıp sonrakine geçer.

//--------- GÜVENLİ SAYI ALMA : TRY PARSE -------------
//int.parse'da kullanıcı harf yazarsa program çöküyordu try.parse bu işi çözüyor.

//Console.Write("Bir sayı gir: ");
//if (int.TryParse(Console.ReadLine(), out int sayi))
//{
//    Console.WriteLine($"Girdiğiniz sayı: {sayi}");
//}
//else
//{
//    Console.WriteLine("Bu bir sayı değil!");
//}
//-- okunuşu: girileni sayıya çevirmeyi dene başarılıysa sonucu sayi değişkenine ata ve if içine gir başarısız ise else'e git
//-- out int sayi kısmını bir kalıp olarak aklımızda tutalım ileride metotlarda göreceğiz.

//--------------------DENEME-------------------------------

//Kullanıcıdan bir sayı al, çift mi tek mi yazdır. (İpucu: sayi % 2 == 0)
//1'den 10'a kadar sayıları for ile yazdır.
//Kullanıcıdan yaş al, 18'den küçükse “Giremezsin”, değilse “Girebilirsin” yazdır.

//1.
//    Console.Write("Bir Sayı Giriniz: ");
//if (int.TryParse(Console.ReadLine(), out int sayi))
//{
//    if (sayi % 2 == 0)
//    {
//        Console.WriteLine("Sayı Çift");
//    }
//    else
//    {
//        Console.WriteLine("Sayı Tek");
//    }
//}

//2.
//for (int i = 1;i <= 10; i++)
//{
//    Console.WriteLine($"Sayı: {i}");
//}

//3.
//Console.Write("Yaşınızı Giriniz: ");
//if (int.TryParse(Console.ReadLine(), out int yas))
//{
//    if (yas < 18)
//    {
//        Console.WriteLine("Giremezsin");
//    }
//    else
//    {
//        Console.WriteLine("Girebilirsin");
//    }
//}

//----------------------------------ANA DENEME-----------------------------------

//Program tuttuğu sayıyı sabit yazsın: int tutulan = 42;
//Kullanıcı tahmin girsin.Her tahminde “Daha büyük”, “Daha küçük” veya “Bildin!” desin.
//Doğru bilene kadar döngü sürsün, sonunda kaç tahminde bildiğini yazsın.

//int tutulan = 27;
//int sayac = 0;

//while (tutulan > 0)
//{
//    Console.Write("Bir sayı girin: ");
//if (int.TryParse(Console.ReadLine(), out int tahmin))
//{
//        if (tahmin < tutulan)
//        {
//            Console.WriteLine("Tahmininiz Küçük");
//            sayac++;
//            Console.WriteLine($"Tahmin sayınız: {sayac}");
//        }
//        else if (tahmin > tutulan)
//        {
//            Console.WriteLine("Tahmininiz Büyük");
//            sayac++;
//            Console.WriteLine($"Tahmin sayınız: {sayac}");
//        }
//        else
//        {
//            Console.WriteLine("Doğru Bildiniz Tebrikler!");
//            sayac++;
//            Console.WriteLine($"Tahmin sayınız: {sayac}");
//            break;
//        }

//}
//else
//{
//        Console.WriteLine("Bu bir sayı değil lütfen bir sayı giriniz.");
//}
//}














