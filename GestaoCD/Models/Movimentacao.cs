using GestaoCD.Enums;
namespace GestaoCD.Models;

public class Movimentacao
{
    public long Id { get; set; }
    public CentroDistribuicao Origem { get; set; }
    public CentroDistribuicao Destino { get; set; }
    public Produto Produto { get; set; }
    public long Quantidade { get; set; }
    public DateTime Data { get; set; }
    public StatusMovimentacao Status { get; set; }
}