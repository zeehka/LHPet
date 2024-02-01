using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    // instancia do tipo cliente
        Cliente cliente1 = new Cliente (01, "Jose Carlos", "334.464.838-10","jose.tavares@tramontina.com","Daniel");
        Cliente cliente2 = new Cliente (02, "Daniel Ferreira", "852.147.963-20","daniel.ferreira@tramontina.com","Bolotinha");
        Cliente cliente3 = new Cliente (03, "Laudemir Tomaz", "963.456.789-30","laudemir.tomaz@tramontina.com","Batatinha");
        Cliente cliente4 = new Cliente (04, "Mequias Fogaça", "789.654.123-50","mequias.fogaca@tramontina.com","Simba");
        Cliente cliente5 = new Cliente (05, "Mizael Fogaça", "159.753.325-30","mizael.fogaca@tramontina.com","Marry");

        // Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

    // instancia do tipo fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01,"Tramontina Sudeste S/A","61.652.608/0001-95","sudeste@tramontina.com");
        Fornecedor fornecedor2 = new Fornecedor(02,"Leroy Merlin","01.438.784/0001-05","leroy@merlin.com");
        Fornecedor fornecedor3 = new Fornecedor(03,"Magazine Luiza","47.950.960/0027-35","magazine@luiza.com");
        Fornecedor fornecedor4 = new Fornecedor(04,"FastShop","25.987.258/0001-95","fast@shop.com");
        Fornecedor fornecedor5 = new Fornecedor(05,"Amazon","56.654.753/0001-89","amazom@brasil.com");

        // Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
