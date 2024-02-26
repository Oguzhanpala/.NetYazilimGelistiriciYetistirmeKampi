using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();

        SelamVer("Ahmet");
        SelamVer("Engin");
        SelamVer("Ayşe");
        SelamVer();

        int sonuc = Topla(6, 58);

        //Diziler /Arays

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        ogrenciler = new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);
        Console.WriteLine();

        Person person1 = new Person();
        person1.FirstName = "Oğuzhan";
        person1.LastName = "Pala";
        person1.DateOfBirtYear = 1997;
        person1.NationalIdentity = 125;

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
        yeniSehirler1.Add("Adana1");
        foreach (string sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }

    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        String mesaj = "Merhaba";
        double tutar = 100000;
        int sayi = 100;
        bool girisYaptiMi = false;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(tutar * 1.18);
    }
}
public class Citizen
{
    public String Ad { get; set; }
    public String Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}