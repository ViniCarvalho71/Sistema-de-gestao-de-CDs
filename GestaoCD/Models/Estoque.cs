namespace GestaoCD.Models;

public class Estoque
{
    public long Id { get; set; }
    public Produto Produto { get; set; }
    public CentroDistribuicao Cd  { get; set; }
    public int Quantidade { get; set; }
}