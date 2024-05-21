using System.Net.Http.Headers;
using Pokedex;

var pikachu = new Pikachu();
pikachu.ShowInfo();

var mew = new Pokemon("Mew", 999, 99);
var mewtwo = new Pokemon("Mewtwo", 999, 99);
var pokemon = new Pokemon();

mew.ShowInfo();
mewtwo.ShowInfo();
pokemon.ShowInfo();

Console.WriteLine("lets add a new Pokemon! Start with a name.");
string pokemonName = Console.ReadLine();
Console.WriteLine("then how much health it has.");
int pokemonHealth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("at last, it's level.");
int pokemonLevel = Convert.ToInt32(Console.ReadLine());
var newPokemon = new Pokemon(name: pokemonName, pokemonHealth, pokemonLevel);
newPokemon.ShowInfo();