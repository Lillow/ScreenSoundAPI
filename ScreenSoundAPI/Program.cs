using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient Client = new())
{


    try
    {
        var resposta = await Client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[1998].ExibirDetalhes();
        //LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}