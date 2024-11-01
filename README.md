# Araba S�n�f� Uygulamas�

Bu proje, C# dilinde `Araba` s�n�f� kullan�larak olu�turulmu� basit bir araba y�netim uygulamas�d�r. Uygulamada, arabalar�n marka, model, renk ve kap� say�s� gibi bilgileri kaydedilir. Kap� say�s�, sadece 2 veya 4 olarak atanabilir; aksi durumda sistem bir uyar� mesaj� verip kap� say�s�n� ge�ersiz kabul eder.

## �zellikler

- **Marka**: Araban�n markas�n� belirtir.
- **Model**: Araban�n modelini belirtir.
- **Renk**: Araban�n rengini belirtir.
- **Kap� Say�s�**: Araban�n kap� say�s�n� belirtir ve sadece 2 veya 4 de�erine izin verir.
  - 2 veya 4 d���nda bir de�er girilirse, kap� say�s� `-1` olarak atan�r ve bir uyar� mesaj� g�r�nt�lenir.

## Proje Yap�s�

- **Araba S�n�f�**: `Marka`, `Model`, `Renk` ve `KapiSayisi` �zelliklerini i�erir.
- **Kaps�lleme**: `KapiSayisi` �zelli�i, �zel bir `get/set` yap�s� kullan�larak yaln�zca 2 veya 4 de�erine izin verir.
- **ArabaBilgileriniYazdir()** Metodu: Araba nesnesinin t�m �zelliklerini konsola yazd�r�r.

## Kullan�m

### �rnek Kod
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
    Renk = "K�rm�z�",
    KapiSayisi = 3  // Ge�ersiz bir kap� say�s� girildi�i i�in uyar� mesaj� verecek ve -1 olarak atayacakt�r
};

araba1.ArabaBilgileriniYazdir();
araba2.ArabaBilgileriniYazdir();

````