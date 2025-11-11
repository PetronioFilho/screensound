
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    // Auto-implemented read-only property
    public string DescricaoResumida => $"{Nome} - {Artista.Nome} ({Duracao} segundos)";
    //public string DescricaoResumida 
    //{
    //    get 
    //    {
    //        return $"{Nome} - {Artista} ({Duracao} segundos)";
    //    } 
    //}

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}