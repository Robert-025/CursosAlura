using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameOfThronesAPI.Modelos
{
    internal class Personagens
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("gender")]
        public string Genero { get; set; }

        [JsonPropertyName("culture")]
        public string Cultura { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Cultura: {Cultura}");
        }
    }
}
