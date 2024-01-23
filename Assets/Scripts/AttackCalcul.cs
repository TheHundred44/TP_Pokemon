using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCalcul : MonoBehaviour
{
    private Pokemon _pokemonPlayer;
    private Pokemon _pokemonTrainer;
    private Attacks _attacks;

    private void Start()
    {
        _pokemonPlayer = GameObject.FindGameObjectWithTag("PokemonPlayer").GetComponent<Pokemon>();
        _pokemonTrainer = GameObject.FindGameObjectWithTag("PokemonTrainer").GetComponent<Pokemon>();
        _attacks = FindAnyObjectByType<Attacks>();
    }

    public void Calcul()
    {
        if (_attacks.TypeOfAttack2 == "Feu")
        {
            if(_pokemonTrainer.Type == "Plante")
            {
                _pokemonPlayer.Damage *= 2;
            }
            else if (_pokemonTrainer.Type == "Eau")
            {
                _pokemonPlayer.Damage /= 2;
            }
        }

        else if (_attacks.TypeOfAttack2 == "Eau")
        {
            if (_pokemonTrainer.Type == "Plante")
            {
                _pokemonPlayer.Damage /= 2;
            }
            else if (_pokemonTrainer.Type == "Feu")
            {
                _pokemonPlayer.Damage *= 2;
            }
        }

        else
        {
            if (_pokemonTrainer.Type == "Eau")
            {
                _pokemonPlayer.Damage *= 2;
            }
            else if (_pokemonTrainer.Type == "Feu")
            {
                _pokemonPlayer.Damage /= 2;
            }
        }

        _attacks.SignatureAttack();
    }
}
