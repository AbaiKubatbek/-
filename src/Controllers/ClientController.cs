using EatAndDrink.Models;
using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            Client client1 = new Client(){Id = 1, FirstName = "ABAI",LastName = "KUBABATBEKOV", PhoneNumber="0705343482", Address="Bishkek,Min-Bulak 7A/1" };
            Client client2 = new Client() { Id = 2, FirstName = "ULUK", LastName = "JANYBEKOV", PhoneNumber = "0705415926", Address = "Bishkek, Gogolya 56" };
            Client client3 = new Client() { Id = 3, FirstName = "ALEKSANDR", LastName = "GULAIEV", PhoneNumber = "0702459996", Address = "Tokmok, Fedrov 2C/4" };
            Client client4 = new Client() { Id = 4, FirstName = "ARTEM", LastName = "LARIONOV", PhoneNumber = "0550728858", Address = "Bishkek, 11 Mkr.24" };
            Client client5 = new Client() { Id = 5, FirstName = "MURAS", LastName = "USUBALIEV", PhoneNumber = "706414542", Address = "Bishkek, Kyzyl-Asker 23" };
            Client client6 = new Client() { Id = 6, FirstName = "DOOLOT", LastName = "TOROGELDI U.", PhoneNumber = "0707663303", Address = "Bishkek, Novopovlovka 15" };
            Client client7 = new Client() { Id = 7, FirstName = "ARTEM", LastName = "SHELUDKO", PhoneNumber = "0773295069", Address = "Ivanovka, Botalieva 40" };
            Client client8 = new Client() { Id = 8, FirstName = "AIBEK", LastName = "ASANOV", PhoneNumber = "0706335535", Address = "Bishkek,Kyzyl-Asker 27" };
            Client client9 = new Client() { Id = 9, FirstName = "AZIRET", LastName = "ERNISBEKOV", PhoneNumber = "0706490595", Address = "Bishkek, Ak-Ordo 11" };
            Array array = new[] {client1, client2,client3,client4,client5,client6,client7,client8,client9};
            return View(array);

        }
        
    }
}
