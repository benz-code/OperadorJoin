using System;
using System.Linq;

namespace joinc
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = (from pokemones in Pokemones.GetPokemones()//indicamos de coleccion extraeremos los datos ejemplo yo en esta extraere los datos de pokemones 
                          join attack in Attack.GetAttacks() // aca colococamos un alias  que seria "attack" 
                          on pokemones.Type equals attack.Type// este es para ver bajo que codicion se ejecutara el join en este seria bajo el topo "fire"
                          where pokemones.Type == "fire"
                          select new { Pokemones = pokemones, Attack = attack }
        );// esta linea estas indicado que se creara un nuevo objeto , esta tiene 2 atributos que seira pokemones y attack
            foreach (var item in result)// se intengra mediante un foreach
            {
                var pokemon = item.Pokemones;//aca extrariamos los datos
                var attack = item.Attack;

                string message = pokemon.Name + " = " + attack.Name;// se genera el mensaje 
                System.Console.WriteLine(message);// se imprimieira nuestro mensaje 
            }
        }
    }
}
