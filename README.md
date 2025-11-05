# Dependency (Composition) - C# Örnekleri

Bu proje, C# programlama dilinde **Composition (Kompozisyon)** ilişkisini gösteren örnekler içermektedir.

## Açıklama

Composition, bir nesnenin başka bir nesnenin bir parçası olması ve yaşam döngüsünün ona bağlı olması durumunu ifade eder. Bu örnekte üç farklı composition senaryosu gösterilmektedir:

### 1. Bilgisayar ve İşlemci
Bir bilgisayarın işlemcisi vardır. Eğer bilgisayar kapanırsa, işlemci de var olamaz çünkü işlemci bilgisayarın bir parçasıdır.

### 2. Otomobil ve Motor
Bir otomobilin motoru vardır. Eğer otomobil yoksa, motor da yok olacaktır. Motor, otomobilin ayrılmaz bir parçasıdır.

### 3. Okul ve Öğrenci
Bir okulda birçok öğrenci olabilir, ancak okul kapandığında öğrenciler de kapanır çünkü okul, öğrencilerin hayatlarını sürdürebileceği bir yerdir.

## Proje Yapısı

```
Dependency (Composition)/
├── Dependency (Composition)/
│   ├── Dependency (Composition).csproj
│   └── Program.cs
└── Dependency (Composition).sln
```

## Gereksinimler

- .NET 8.0 SDK veya üzeri
- Visual Studio 2022 veya Visual Studio Code (isteğe bağlı)

## Çalıştırma

Projeyi çalıştırmak için:

```bash
cd "Dependency (Composition)/Dependency (Composition)"
dotnet run
```

## Kod Örnekleri

### Bilgisayar ve İşlemci
```csharp
class Bilgisayar
{
    public İslemci İslemci { get; private set; }
    
    public Bilgisayar(string model)
    {
        Model = model;
        İslemci = new İslemci(8, 3); // Bilgisayar oluşturulduğunda işlemci de oluşturulur
    }
}
```

### Otomobil ve Motor
```csharp
class Otomobil
{
    public Motor Motor { get; private set; }
    
    public Otomobil(string marka)
    {
        Marka = marka;
        Motor = new Motor("V12", 155); // Otomobil oluşturulduğunda motor da oluşturulur
    }
}
```

### Okul ve Öğrenci
```csharp
class Okul
{
    public Ogrenci Ogrenci { get; private set; }
    
    public Okul(string ad)
    {
        Ad = ad;
        Ogrenci = new Ogrenci("Beşir Kesen", 19); // Okul oluşturulduğunda öğrenci de oluşturulur
    }
}
```

## Özellikler

- Composition ilişkisinin C# ile nasıl uygulandığını gösterir
- Üç farklı gerçek dünya senaryosu ile örnekler
- Temiz ve anlaşılır kod yapısı
- Türkçe yorumlar ve açıklamalar

## Lisans

Bu proje eğitim amaçlıdır.

