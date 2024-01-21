using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCalcul : MonoBehaviour
{
    private Pokemon _pokemonTrainer1;
    private Pokemon _pokemonTrainer2;
    private Attacks _attacks;

    private void Start()
    {
        _pokemonTrainer1 = FindAnyObjectByType<Pokemon>(); 
        _pokemonTrainer2 = FindAnyObjectByType<Pokemon>(); //à récup autrepart
        _attacks = FindAnyObjectByType<Attacks>();
    }

    public void Calcul()
    {
        if (_attacks.TypeOfAttack2 == "Feu")
        {
            if(_pokemonTrainer2.Type == "Plante")
            {
                _pokemonTrainer1.Damage *= 2;
            }
            else if (_pokemonTrainer2.Type == "Eau")
            {
                _pokemonTrainer1.Damage /= 2;
            }
        }

        if (_attacks.TypeOfAttack2 == "Eau")
        {
            if (_pokemonTrainer2.Type == "Plante")
            {
                _pokemonTrainer1.Damage /= 2;
            }
            else if (_pokemonTrainer2.Type == "Feu")
            {
                _pokemonTrainer1.Damage *= 2;
            }
        }

        if (_attacks.TypeOfAttack2 == "Plante")
        {
            if (_pokemonTrainer2.Type == "Eau")
            {
                _pokemonTrainer1.Damage *= 2;
            }
            else if (_pokemonTrainer2.Type == "Feu")
            {
                _pokemonTrainer1.Damage /= 2;
            }
        }

        _attacks.SignatureAttack();
    }
}
