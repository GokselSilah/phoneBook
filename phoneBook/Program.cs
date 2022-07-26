// See https://aka.ms/new-console-template for more information

using System.Collections;
using phoneBook;



Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :");
Console.WriteLine("******************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarıyı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncellemek");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");


string input = Console.ReadLine();


PhoneManger phoneManager = new PhoneManger();


if (input == "1")
{
    phoneManager.Add();
    //phoneManager.GetAll();
}

else if(input == "2") 
{
    phoneManager.Remove();
    //phoneManager.GetAll();
}

else if (input == "3")
{
    phoneManager.Update();
    //phoneManager.GetAll();
}

else if (input == "4") 
{
    phoneManager.GetAll();
}

else if (input == "5")
{
    phoneManager.Search();
}

else
{

}