public class DiscoverCommand
{
    Pokedex Pokedex;

    public DiscoverCommand(Pokedex pokedex)
    {
        Pokedex = pokedex;
    }

    public void Discover(string name)
    {
        Pokemon pokemon = Pokedex.Get(name);
        pokemon.Discover();
    }
}