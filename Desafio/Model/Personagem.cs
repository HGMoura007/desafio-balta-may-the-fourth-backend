public class Personagem : ModelBase
{
    public string Nome { get; set; }
    public string Altura { get; set; }
    public string Pesa { get; set; }
    public string CorCabelo { get; set; }
    public string CorPele { get; set; }
    public string CorOlho { get; set; }
    public string AnoNascimento { get; set; }
    public string Genero { get; set; }
    public Planeta Planeta { get; set; }
    public List<Filme> Filmes { get; set; }
}

