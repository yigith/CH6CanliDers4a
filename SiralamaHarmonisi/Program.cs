using SiralamaHarmonisi;

// 5 kişiden oluşan bir kişi dizisi
Kisi[] kisiler =
{
    new Kisi() { Ad = "Melis", Yas = 23 },
    new Kisi() { Ad = "İlayda", Yas = 20 },
    new Kisi() { Ad = "Ezgi", Yas = 27 },
    new Kisi() { Ad = "Burak", Yas = 22 },
    new Kisi() { Ad = "Mehmet Ali", Yas = 28 }
};

foreach (Kisi k in kisiler.OrderBy(x => x.Yas))
{
    Console.WriteLine(k.Ozet());
}

Console.ReadKey();

// Öğrencileri adına göre de sıralasak
// yaşına göre de sıralasak verileri 
// bir ara da kaldı
// uçaktaki valizlerin sırası değişse de
// içindeki eşyaların bir arada kalmaya
// devam etmesi misali..