using Microsoft.AspNetCore.SignalR;

namespace LHPet.Models;

public class Cliente
{

public int Id {get; set;}
public string? Nome {get; set;}
public string? CPF {get; set;}
public string? Email {get; set;}
public string? Paciente {get; set;}


public Cliente(int id, string nome, string CPF, string Email, string Paciente)
{
    this.Id = id;
    this.Nome = nome;
    this.CPF = CPF;
    this.Email = Email;
    this.Paciente = Paciente;
}

}
