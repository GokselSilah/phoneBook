using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class PhoneManger
    {
        List<Phone> phones = new List<Phone>()
        {
            new Phone() { Name = "Göksel", Surname = "Silah", PhoneNumber = "5555555" },
            new Phone() { Name = "Cemre", Surname = "Silah", PhoneNumber = "5321234" },
            new Phone() { Name = "Can", Surname = "Dirlik", PhoneNumber = "8564007" },
            new Phone() { Name = "Umut", Surname = "Güneş", PhoneNumber = "4521453" },
            new Phone() { Name = "Diren", Surname = "Yeşil", PhoneNumber = "8560666" }
        };


        public void Add()
        {
            Console.WriteLine("İsim Giriniz             :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz          :");
            string surName = Console.ReadLine();
            Console.WriteLine("Telefon Numarası Giriniz :");
            string phoneNumber = Console.ReadLine();

            foreach (var number in phones)
            {
                if (number.Name == name && number.Surname == surName && number.PhoneNumber == phoneNumber)
                {
                    Console.WriteLine("Bu Numara Daha Önce Kaydedilmiştir.");
                }

            }

            phones.Add(new Phone() { Name = name, Surname = surName, PhoneNumber = phoneNumber });

        }

        public void Remove()
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz Kişinin Adını ve ya Soyadını Giriniz :");
            string remove = Console.ReadLine();

            var result = phones.FirstOrDefault(p => p.Name == remove || p.Name == remove);
            phones.Remove(result);
        }

        public void Update()
        {
            Console.WriteLine("Lütfen Güncellemek İstediğiniz Kişinin Adını ve ya Soyadını Giriniz :");
            string update = Console.ReadLine();


            var result = phones.SingleOrDefault(p => p.Name == update || p.Surname == update);


            Console.WriteLine("Yeni İsmi Giriniz :");
            string newName = Console.ReadLine();
            Console.WriteLine("Yeni Soyismi Giriniz :");
            string newSurname = Console.ReadLine();
            Console.WriteLine("Yeni Telefon Numarası Giriniz:");
            string newPhoneNumber = Console.ReadLine();

            result.Name = newName;
            result.Surname = newSurname;
            result.PhoneNumber = newPhoneNumber;
            

        }

        public void GetAll()
        {
            foreach (var item in phones)
            {
                Console.WriteLine($"İsim: {item.Name}");
                Console.WriteLine($"Soyisim: {item.Surname}");
                Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}");

            }
        }

        public void Search()
        {
            Console.WriteLine("İsim veya Soyisim ile arama yapmak için: (1)");
            Console.WriteLine("Telefon numarası ile arama yapmak için: (2)");
            var input = Console.ReadLine();
            Console.WriteLine("İsim veya Soyisim giriniz :");
            string s = Console.ReadLine();


            if (input == "1")
            {
                var result = phones.FirstOrDefault(p => p.Name == s || p.Surname == s);

                Console.WriteLine($"İsim: {result.Name}");
                Console.WriteLine($"Soyisim: {result.Surname}");
                Console.WriteLine($"Telefon Numarası: {result.PhoneNumber}");
            }

            else if (input == "2")
            {
                var result = phones.FirstOrDefault(p => p.PhoneNumber == s);

                Console.WriteLine($"İsim: {result.Name}");
                Console.WriteLine($"Soyisim: {result.Surname}");
                Console.WriteLine($"Telefon Numarası: {result.PhoneNumber}");
            }


        }
    }
}
