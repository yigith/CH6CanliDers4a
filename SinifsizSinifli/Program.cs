using SinifsizSinifli;

Ogrenci o1 = new Ogrenci();
o1.Ad = "Burak";
o1.Yas = 23;

Ogrenci o2 = new Ogrenci() { Ad = "Serhat", Yas = 22 };

o1.KunyeGoster();
o2.KunyeGoster();






#region Class kullanmadan
//string ad1 = "Burak";
//int yas1 = 23;
//string ad2 = "Serhat";
//int yas2 = 22;
//string kunye1 = $"{ad1} adlı öğrenci {yas1} yaşındadır.";
//string kunye2 = $"{ad2} adlı öğrenci {yas2} yaşındadır.";
//Console.WriteLine(kunye1);
//Console.WriteLine(kunye2); 
#endregion

Console.ReadKey();