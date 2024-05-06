using System;: Bu ifade, System adlı bir namespace'i projeye dahil eder. Bu namespace, temel C# türlerini ve işlevlerini içerir.
class Kitap: Kitap sınıfını tanımlar. Bu sınıf, kitapların özelliklerini (ad, yazar, yıl) ve bir kitabı yazdırmak için ToString() metodunu içerir.
class Program: Program sınıfını tanımlar. Bu sınıf, kütüphane işlemlerini gerçekleştiren ana programı içerir.
List<Kitap> kitaplar = new List<Kitap>();: Kitapların saklanacağı bir List koleksiyonu oluşturur.
Main metodu: Programın giriş noktasını belirtir. Bu metod, kullanıcının menüden seçim yapmasını sağlar ve ilgili işlevleri çağırır.
KitapEkle metodu: Kullanıcıdan bir kitap eklemesini ister ve yeni bir Kitap nesnesi oluşturarak koleksiyona ekler.
KitapAra metodu: Kullanıcıdan bir kitap adı alır ve koleksiyonda bu ada sahip tüm kitapları bulur.
TumKitaplariListele metodu: Koleksiyonda bulunan tüm kitapları ekrana yazdırır.
