# Araba Sýnýfý Uygulamasý

Bu proje, C# dilinde `Araba` sýnýfý kullanýlarak oluþturulmuþ basit bir araba yönetim uygulamasýdýr. Uygulamada, arabalarýn marka, model, renk ve kapý sayýsý gibi bilgileri kaydedilir. Kapý sayýsý, sadece 2 veya 4 olarak atanabilir; aksi durumda sistem bir uyarý mesajý verip kapý sayýsýný geçersiz kabul eder.

## Özellikler

- **Marka**: Arabanýn markasýný belirtir.
- **Model**: Arabanýn modelini belirtir.
- **Renk**: Arabanýn rengini belirtir.
- **Kapý Sayýsý**: Arabanýn kapý sayýsýný belirtir ve sadece 2 veya 4 deðerine izin verir.
  - 2 veya 4 dýþýnda bir deðer girilirse, kapý sayýsý `-1` olarak atanýr ve bir uyarý mesajý görüntülenir.

## Proje Yapýsý

- **Araba Sýnýfý**: `Marka`, `Model`, `Renk` ve `KapiSayisi` özelliklerini içerir.
- **Kapsülleme**: `KapiSayisi` özelliði, özel bir `get/set` yapýsý kullanýlarak yalnýzca 2 veya 4 deðerine izin verir.
- **ArabaBilgileriniYazdir()** Metodu: Araba nesnesinin tüm özelliklerini konsola yazdýrýr.

## Kullaným

### Örnek Kod
```csharp
Araba araba1 = new Araba()
{
    Marka = "Toyota",
    Model = "Corolla",
    Renk = "Beyaz",
    KapiSayisi = 4
};

Araba araba2 = new Araba()
{
    Marka = "Ford",
    Model = "Mustang",
    Renk = "Kýrmýzý",
    KapiSayisi = 3  // Geçersiz bir kapý sayýsý girildiði için uyarý mesajý verecek ve -1 olarak atayacaktýr
};

araba1.ArabaBilgileriniYazdir();
araba2.ArabaBilgileriniYazdir();

````