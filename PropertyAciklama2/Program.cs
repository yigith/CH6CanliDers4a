using PropertyAciklama2;

Calisan simitci = new Calisan();
simitci.Ad = "Berkan"; // set
simitci.Yas = 24;
simitci.KunyeYazdir();

Console.WriteLine(simitci.Ad); // get

Calisan menajer = new Calisan();
menajer.Ad = "Yaşar";
menajer.Yas = -23;

menajer.KunyeYazdir();

Console.ReadKey();