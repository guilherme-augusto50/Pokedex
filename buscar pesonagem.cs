using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class buscar_pesonagem
    {
        public static async Task<Pokemon> Buscar_pokemon(string pkm)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{pkm}";
            


        }
    }
}
