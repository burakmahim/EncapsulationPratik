using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPratik
{
    public class Araba
    {
        // Özellikler
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int kapiSayisi;

        // Kapı Sayısı özelliği için kapsülleme
        public int KapiSayisi
        {
            get { return kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Geçersiz bir değer girildi, Kapı Sayısı -1 olarak ayarlandı.");
                    kapiSayisi = -1;
                }
            }
        }

        // Bilgileri yazdırmak için bir metot
        public void ArabaBilgileriniYazdir()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
        }
    }
}
