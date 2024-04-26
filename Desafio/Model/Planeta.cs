
public class Planeta : ModelBase
{
    public string Nome { get; set; }
    public string PeriodoRotacao { get; set; }
    public string PeriodoOrbita { get; set; }
    public string Diametro { get; set; }
    public string Clima { get; set; }
    public string Gravidade { get; set; }
    public string Terreno { get; set; }
    public string SuperficeAquatica { get; set; }
    public string Populacao { get; set; }
    public List<Personagem> Personagens { get; set; }
    public List<Filme> Filmes { get; set; }
}

