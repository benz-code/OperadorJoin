using System;
using System.Collections.Generic;
using System.Text;

namespace joinc
{
    class Pokemones
    {
        //tanto como en la clase de pokemmon y de attack con metodo estaticos todos en forma de una lista de objetos que retorna una lista  ejemplo en el pokemon 
        // podemos ver los tipos de pokemones que tenemos en la lista 
        // en la lista de attakaes solo puse los tenemos de tipo fuego  que serian los atakes para pokemones tipo fuegos 
        string _name;
        string _type;
        int _baseexperience;
        int _height;
        int _weight;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int BaseExperience
        {
            get { return _baseexperience; }
            set { _baseexperience = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Pokemones(string name, string type, int baseExperience, int height, int weight)
        {
            this.Name = name;
            this.Type = type;
            this.BaseExperience = baseExperience;
            this.Height = height;
            this.Weight = weight;
        }
        public static List<Pokemones> GetPokemones()
        {
            return new List<Pokemones>
            {
                new Pokemones(" Balbusaur", "poison", 64, 7, 69),
                new Pokemones(" Ivaysaur", "poison", 142, 10, 130),
                new Pokemones(" venusaur", "poison", 236,20, 1000),
                new Pokemones(" Charmander", "fire", 62, 7, 85),
                new Pokemones(" Charmeleon", "fire", 142, 11, 190),
                new Pokemones(" Charizard ", "fire", 240, 17, 905),
                new Pokemones("wartortle", "water", 63, 5, 90),
                new Pokemones(" Blastoise", "water", 239, 16, 855),
                new Pokemones(" metapod", "bug", 72, 7, 99),
                new Pokemones(" Butterfree", "bug", 178, 11, 320),
            };
        }
    }
    public class Attack
    {
        string _name;
        int _damage;
        string _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Attack(string name, int damaage, string type)
        {
            this.Name = name;
            this.Damage = damaage;
            this.Type = type;
        }

        public static List<Attack> GetAttacks()
        {
            return new List<Attack>
            {
                new Attack("Eruption", 150, "fire"),
                new Attack("fire blast", 110, "fire"),
                new Attack("fire punch", 75, "fire"),
                new Attack("flame wheel", 50, "fire"),

            };
        }
    }
}
