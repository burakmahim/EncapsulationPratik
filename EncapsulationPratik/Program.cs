using EncapsulationPratik;

// Geçerli kapı sayısı ile araba nesnesi
Araba araba1 = new Araba()
{
    Marka = "Toyota",
    Model = "Corolla",
    Renk = "Beyaz",
    KapiSayisi = 4
};

// Geçersiz kapı sayısı ile araba nesnesi
Araba araba2 = new Araba()
{
    Marka = "Ford",
    Model = "Mustang",
    Renk = "Kırmızı",
    KapiSayisi = 3
};

// Araba bilgilerini yazdırma
araba1.ArabaBilgileriniYazdir();
araba2.ArabaBilgileriniYazdir();
