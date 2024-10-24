
using PropertyAciklama;

Calisan kaldirimci = new Calisan();
kaldirimci.Ad = "Aykan";
kaldirimci.Yas = 34;

Calisan tirSoforu = new();
tirSoforu.Ad = "Hamit";
tirSoforu.Yas = -33;

kaldirimci.KunyeYazdir();
tirSoforu.KunyeYazdir();

Console.ReadKey();

/*
PROBLEM: Yukarıda gözlemlediğimiz üzere 
bir field olan Yas üyesi public
ile dışarıya açıldığından 
sınıfı kullanan kişi doğrudan
istediği değeri aktarabiliyor.
Bu da istenmeyen değerlerin 
kolaylıkla atanmasını mümkün kılıyor.
 */
