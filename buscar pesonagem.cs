using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokemon
{
    public class buscar_pesonagem
    {
        public static Pokemon Buscar_pokemon(string id)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{id}";
            string img = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png";
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(json);
                dynamic resultado = JsonConvert.DeserializeObject(json);
                Pokemon pkm = new Pokemon
                {
                    Id = resultado.id,
                    Name = resultado.name,
                    Height = resultado.height,
                    Weight = resultado.weight,
                    imagem = resultado.sprites.master

                };
                return pokemon;

            }

        }
    }
}
