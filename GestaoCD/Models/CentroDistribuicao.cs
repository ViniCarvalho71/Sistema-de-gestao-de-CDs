namespace GestaoCD.Models;

public class CentroDistribuicao
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }
}