using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade {
            get
            {
                string[] tonalidades = ["C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"];
                return tonalidades[Key];
            } }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Música: {Nome}\nArtista: {Artista}\nDuração: {Duracao / 1000}seg\nGénero: {Genero}\nTonalidade: {Tonalidade}");
        }
    }


}
