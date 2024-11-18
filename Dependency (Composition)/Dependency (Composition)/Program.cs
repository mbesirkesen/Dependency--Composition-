using System;
//Bir bilgisayarın işlemcisi vardır. Eğer bilgisayar kapanırsa, işlemci de var olamaz çünkü işlemci bilgisayarın bir parçasıdır.
class İslemci
{
    public int Cekirdekler { get; private set; }
    public int Frekans { get; private set; }
    public İslemci(int cekirdek, int frekans)
    {
        Cekirdekler= cekirdek;
        Frekans = frekans;
    }
    public void İslemciBilgisi()
    {
        Console.WriteLine($"Cekirdek Sayısı : { Cekirdekler}\nFrekansı: { Frekans}");
    }
}
class Bilgisayar
{
    public string Model { get; private set; }
    public İslemci İslemci { get; private set; }
    public Bilgisayar(string model)
    {
        Model = model;
        İslemci = new İslemci(8, 3); // Bilgisayar olusturuldugunda bir İşlemci de oluşturulur
    }
}

//Bir otomobilin motoru vardır. Eğer otomobil yoksa, motor da yok olacaktır. Motor, otomobilin ayrılmaz bir parçasıdır.

class Motor
{
    public string Tip { get; private set; }
    public int Güc {  get; private set; }
    public Motor(string tip, int güc)
    {
        Tip = tip;
        Güc = güc;
    }

    public void MotorBilgisi()
    {
        Console.WriteLine($"Motor Gücü : {Güc}\nTipi: {Tip}");
    }
}
class Otomobil
{
    public string Marka { get; private set; }
    public Motor Motor { get; private set; } 
    public Otomobil(string marka)
    {
        Marka = marka;
        Motor = new Motor("V12",155);//Otomobil oluşturulduğunda bir motor da oluşturulur
    }
}

//Bir okulda birçok öğrenci olabilir, ancak okul kapandığında öğrenciler de kapanır çünkü okul, öğrencilerin hayatlarını sürdürebileceği bir yerdir.

class Ogrenci
{
    public string Ad { get; private set; }
    public int Yas {  get; private set; }
    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }
    public void OgrenciBilgisi()
    {
        Console.WriteLine($"Ogrencinin Adı : {Ad}\nYaşı: {Yas}");
    }
}
class Okul
{
    public string Ad { get; private set; }
    public Ogrenci Ogrenci { get; private set; }
    public Okul(string ad)
    {
        Ad = ad;
        Ogrenci =new Ogrenci("Beşir Kesen",19);// Okul olusturuldugunda ogrenci de olusturulur
    }
}