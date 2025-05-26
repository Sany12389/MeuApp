namespace MeuApp.Models;

public class Professores
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    // Navigation properties can be added here if needed for relationships
}