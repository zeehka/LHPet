namespace LHPet.Models;

public class Fornecedor

{
public int Id {get; set;}
public string? Nome {get; set;}
public string? Cnpj {get; set;}
public string? Email {get; set;}


    public Fornecedor(int id, string Nome, string Cnpj, string Email)
    {
        this.Id = Id;
        this.Nome = Nome;
        this.Cnpj = Cnpj;
        this.Email = Email;
    }




}