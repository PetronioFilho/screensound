Episodio ep1 = new Episodio(1, "Introdução ao Screen Sound", 45);
ep1.AdicionarConvidados("Alice");
ep1.AdicionarConvidados("Bob");
Console.WriteLine($"Resumo do Episódio: {ep1.Resumo}");

Episodio ep2 = new Episodio(2, "Entrevista com Desenvolvedores", 60);
ep2.AdicionarConvidados("Charlie");
ep2.AdicionarConvidados("Diana");
Console.WriteLine($"Resumo do Episódio: {ep2.Resumo}");

Podcast podcast = new Podcast("Screen Sound", "Eve");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


Console.ReadKey();