using Microsoft.AspNetCore.Authentication;

namespace Curso_Udemy_API.Models;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Celular { get; set; }
    public string? Endereco { get; set; }
    public string? EndNumero { get; set; }
    public string? EndComplemento { get; set; }
    public string? Bairro { get; set; }
    public string? Email { get; set; }
    public string? RazaoSocial{ get; set; }
    public string? CNPJeCPF { get; set; }

}
