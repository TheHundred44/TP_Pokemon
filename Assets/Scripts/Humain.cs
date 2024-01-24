using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Humain : MonoBehaviour
{
    public HumainScriptable humainScriptable;
    public string NameTrainer;
    public List<Pokemon> ListPokemon;
    public int NBPokemonWanted;
    public List<Pokemon> TeamPokemon;
    public Sprite Sprite;

    private void Start()
    {
        /*NameTrainer = humainScriptable.NameTrainer;
        ListPokemon = humainScriptable.ListPokemon;
        NBPokemonWanted = humainScriptable.NbPokemon;
        Sprite = humainScriptable.SpriteHuman;*/

        AttributionPokemon();
    }

    public virtual void CapacityTrainer()
    {

    }

    public void AttributionPokemon()
    {
        if (ListPokemon.Count >= NBPokemonWanted)
        {
            for (int i = 0; i < NBPokemonWanted; i++)
            {
                Pokemon _pokemonrandom = PokemonRandom();
                TeamPokemon.Add(_pokemonrandom);
            }

        }
        else
        {
            Debug.LogError("La liste des Pokémon disponibles est insuffisante.");
        }

        if (this.tag == "Player")
        {
            TeamPokemon[0].tag = "PokemonPlayer";
        }
    }

    Pokemon PokemonRandom()
    {
        return ListPokemon[Random.Range(0, ListPokemon.Count)];
    }
}

