class Episodio{

    List<Episodio> episodio = new List<Episodio>();
    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public int Duracao { get; set; }
    public int Ordem { get; }
    public string Resumo => $"Episodio: {Titulo} com duração de {Duracao}, {string.Join(",", convidados)}";
    public string Titulo {get;}

    public List<string> convidados = new List<string>();
    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}