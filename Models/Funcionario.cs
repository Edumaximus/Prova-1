using System.ComponentModel.DataAnnotations;

namespace patrickJesusSuprano.Models;

public class Funcionario{

    public string? funcionarioId{get; set;}
    public string? Cpf{get; set;}
    public string? Nome{get; set;}

    public Funcionario(string nome, string cpf){
        funcionarioId = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }

    

}