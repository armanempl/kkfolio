using System;

namespace WalidacjaEmaili
{
    class Program
    {
        public class Osoba
        {
            public string Imie;
            public string Nazwisko;
            public string Email;
        }

        public class AdresOsoby
        {
            public string Miasto;
            public string Ulica;
            public int NrDomu;
        }

        class EmailValidator
        {
            public static void ValidateEmail(string emailcheck)
            {
                if (!emailcheck.Contains("@") || !emailcheck.Contains("."))
                {
                    Console.WriteLine("Niepoprawny adres");
                    throw new FormatException("Adres jest niepoprawny, spróbuj ponownie");

                }
            }
        }
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.Imie = "Janusz";
            osoba1.Nazwisko = "Kowalski";
            AdresOsoby osoba1o = new AdresOsoby();
            osoba1o.Miasto = "Nowy Sącz";
            osoba1o.Ulica = "Szkolna";
            osoba1o.NrDomu = 17;
            osoba1.Email = "jkowalskigmail.com";
            Console.WriteLine(osoba1.Imie + " " + osoba1.Nazwisko + " " + osoba1o.Miasto + " " + osoba1o.Ulica + " " +
                osoba1o.NrDomu + " " + osoba1.Email);
            EmailValidator.ValidateEmail(osoba1.Email);
        }
    }
}
