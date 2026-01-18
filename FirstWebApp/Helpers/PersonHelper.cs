using FirstWebApp.MyModel;

namespace FirstWebApp.Helpers;

public static class PersonHelper
{
    public static List<Person> GetPeople()
    {
        var people = new List<Person>()
        {
            new Person(){ Id = Guid.NewGuid(), Name = "Kamran", Age = 26, Address = "Baki", Email = "kamran1@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Elvin", Age = 30, Address = "Gence", Email = "elvin2@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Nurlan", Age = 28, Address = "Sumqayit", Email = "nurlan3@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Rashad", Age = 35, Address = "Baki", Email = "rashad4@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Orxan", Age = 24, Address = "Sheki", Email = "orxan5@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Aysel", Age = 27, Address = "Baki", Email = "aysel6@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Leyla", Age = 29, Address = "Gence", Email = "leyla7@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Nigar", Age = 31, Address = "Sumqayit", Email = "nigar8@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Gunel", Age = 25, Address = "Lenkeran", Email = "gunel9@gmail.com"},
            new Person(){ Id = Guid.NewGuid(), Name = "Sevda", Age = 33, Address = "Baki", Email = "sevda10@gmail.com"},

            //new Person(){ Id = Guid.NewGuid(), Name = "Murad", Age = 34, Address = "Gence", Email = "murad11@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Tural", Age = 22, Address = "Baki", Email = "tural12@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Elnur", Age = 36, Address = "Sumqayit", Email = "elnur13@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Samir", Age = 27, Address = "Sheki", Email = "samir14@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Aydin", Age = 32, Address = "Baki", Email = "aydin39@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Zaur", Age = 38, Address = "Gence", Email = "zaur16@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Farid", Age = 29, Address = "Sumqayit", Email = "farid17@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Anar", Age = 41, Address = "Baki", Email = "anar18@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Vusal", Age = 26, Address = "Sheki", Email = "vusal19@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Ramin", Age = 35, Address = "Lenkeran", Email = "ramin20@gmail.com"},

            //new Person(){ Id = Guid.NewGuid(), Name = "Ilkin", Age = 23, Address = "Baki", Email = "ilkin21@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Aqil", Age = 28, Address = "Gence", Email = "aqil22@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Cavid", Age = 31, Address = "Sumqayit", Email = "cavid23@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Rauf", Age = 37, Address = "Baki", Email = "rauf24@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Kenan", Age = 24, Address = "Sheki", Email = "kenan25@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Nihad", Age = 27, Address = "Baki", Email = "nihad26@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Elmar", Age = 39, Address = "Gence", Email = "elmar27@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Adil", Age = 33, Address = "Sumqayit", Email = "adil28@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Faiq", Age = 42, Address = "Baki", Email = "faiq29@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Sadiq", Age = 45, Address = "Sheki", Email = "sadiq30@gmail.com"},

            //new Person(){ Id = Guid.NewGuid(), Name = "Aydin", Age = 34, Address = "Baki", Email = "aydin31@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Ruslan", Age = 28, Address = "Gence", Email = "ruslan32@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Shahin", Age = 36, Address = "Sumqayit", Email = "shahin33@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Ismayil", Age = 40, Address = "Baki", Email = "ismayil34@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Emin", Age = 21, Address = "Sheki", Email = "emin35@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Nazim", Age = 47, Address = "Baki", Email = "nazim36@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Yusif", Age = 26, Address = "Gence", Email = "yusif37@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Rovshan", Age = 38, Address = "Sumqayit", Email = "rovshan38@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Mahir", Age = 29, Address = "Baki", Email = "mahir39@gmail.com"},
            //new Person(){ Id = Guid.NewGuid(), Name = "Polad", Age = 44, Address = "Sheki", Email = "polad40@gmail.com"},
        };

        return people;
    }

}
