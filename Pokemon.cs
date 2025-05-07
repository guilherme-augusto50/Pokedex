using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<PokemonType> Types { get; set; }
        public List<PokemonAbility> Abilities { get; set; }
    }
    public class PokemonType
    {
        public string Type { get; set; }
    }

    public class PokemonAbility
    {
        public string Ability { get; set; }
    }
}
