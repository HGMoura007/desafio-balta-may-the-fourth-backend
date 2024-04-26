using System;
using System.Collections.Generic;
using System.Reflection;


public class Filme : ModelBase
{
    public string Titulo { get; set; }

    public string Episodio { get; set; }

    public string TextoAbertura { get; set; }

    public string Diretor { get; set; }

    public string Produtor { get; set; }

    public DateTime DataLancamento { get; set; }

    public List<Personagem> Personagens { get; set; }

    public List<Planeta> Planetas { get; set; }

    public List<Veiculo> VeículosFilme { get; set; }

    public List<NaveEstelar> NavesEstelares { get; set; }

}



