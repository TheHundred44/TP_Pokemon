using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pierre : Humain
{
    Pokemon _pokemonPlayer; 
    Pokemon _pokemonTrainer;

    GameObject _playerPlayerGameObject;
    GameObject _trainerPlayerGameObject;

    public Attacks _attacks;

    BattleManager _battleManager;
    private void Awake()
    {
        _playerPlayerGameObject = GameObject.FindGameObjectWithTag("PokemonPlayer");
        _pokemonPlayer = _playerPlayerGameObject.GetComponent<Pokemon>();

        _trainerPlayerGameObject = GameObject.FindGameObjectWithTag("PokemonTrainer");
        _pokemonTrainer = _trainerPlayerGameObject.GetComponent<Pokemon>();

        _battleManager = FindAnyObjectByType<BattleManager>();
    }
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

        _battleManager.ChoiceAttackIA();
        _battleManager._attacks.UseAttackTrainer(_pokemonTrainer.Damage);
        _battleManager.VerificationLife(_pokemonPlayer.PV, _battleManager._humainPlayer);
    }

    void HealthAllPokemon()
    {
        _attacks.UseAttackPlayer(-_pokemonTrainer.PVMax);
        _attacks.UseAttackTrainer(-_pokemonPlayer.PVMax);
    }

    void HealthPokemonPlayer()
    {
        _attacks.UseAttackTrainer(-_pokemonPlayer.PVMax);
    }
}
