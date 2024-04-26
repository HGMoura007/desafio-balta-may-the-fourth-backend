
public class Veiculo : ModelBase
{
    public string Nome { get; set; }
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public string CustoEmCredito { get; set; }
    public string Comprimento { get; set; }
    public string VelocidadeMaxima { get; set; }
    public string Tripulacao { get; set; }
    public string Passageiros { get; set; }
    public string CapacidadeCarga { get; set; }
    public string Consumiveis { get; set; }
    public string Classe { get; set; }
    public List<Filme> Filmes { get; set; }
}

