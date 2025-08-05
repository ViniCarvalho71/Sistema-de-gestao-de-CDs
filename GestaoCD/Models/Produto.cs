namespace GestaoCD.Models;

public class Produto
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public decimal Unidade { get; set; }
}