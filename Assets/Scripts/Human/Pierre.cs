using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pierre : Humain
{

    public override void CapacityTrainer()
    {
        int nombreAleatoire = Random.Range(1, 2);
       
        if (nombreAleatoire == 1)
        {
            HealthAllPokemon();
        }
        else
        {
            HealthPokemonPlayer();
        }
    }

    private void HealthAllPokemon()
    {
        
    }

    private void HealthPokemonPlayer()
    {

    }
}
