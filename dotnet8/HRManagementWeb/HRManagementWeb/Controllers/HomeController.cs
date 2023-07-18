using HRManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace HRManagementWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            Console.WriteLine(" Privacy HTTP POST Request Processing Logic is called..");
            var filePath = "D:\\Dot_Net\\dotnet7\\HRManagementWeb\\CustomerList.json";
            if(System.IO.File.Exists(filePath))
            {
                var json=System.IO.File.ReadAllText(filePath);
                var customers=JsonConvert.DeserializeObject<List<Customer>>(json);
                var matchedCustomer=customers.FirstOrDefault(c=>c.Email==email && c.Password==password);
                if(matchedCustomer!=null)
                {
                    return RedirectToAction("list");
                }
            }
            return RedirectToAction("login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
       private static  List<Customer> customers = new List<Customer>();
        [HttpPost]
        public IActionResult Register(string email, string password,string fname,string lname,string phone)
        {

            Customer c=new Customer();
            c.Phone = phone;
            c.Email = email;
            c.Password = password;
            c.FirstName = fname;
            c.LastName= lname;
            customers.Add(c);
            var filePath = "D:\\Dot_Net\\dotnet7\\HRManagementWeb\\CustomerList.json";
            var json=JsonConvert.SerializeObject(customers);
            System.IO.File.WriteAllText(filePath, json);
            return RedirectToAction("list");
        }
      
        public IActionResult List()
        {
            var filePath = "D:\\Dot_Net\\dotnet7\\HRManagementWeb\\CustomerList.json";
            if(System.IO.File.Exists(filePath))
            {
                var json=System.IO.File.ReadAllText(filePath);
                var customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            return View(customers);
            }
            return View(new List<Customer>());
        }
    }
}