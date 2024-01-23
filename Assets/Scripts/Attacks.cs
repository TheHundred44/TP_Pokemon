using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    protected Pokemon _pokemon;

    public string NameOfAttack = "Charge";
    public string TypeOfAttack = "Normal";

    public string NameOfAttack2;
    public string TypeOfAttack2;

    protected TMP_Text _nameOfAttack2;

    protected UIManager _uiManager;

    Pokemon _pokemonPlayer;
    Pokemon _pokemonTrainer;

    public virtual void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
        _uiManager = FindAnyObjectByType<UIManager>();
        _nameOfAttack2 = GameObject.Find("Attack2Text").GetComponent<TMP_Text>();

        _pokemonPlayer = GameObject.FindGameObjectWithTag("PokemonPlayer").GetComponent<Pokemon>();
        _pokemonTrainer = GameObject.FindGameObjectWithTag("PokemonTrainer").GetComponent<Pokemon>();


    }

    public void Charge()
    {
        _pokemon.Damage = (_pokemon.Attack * 20) / 100;
        UseAttackPlayer(_pokemon.Damage);

    }

    public virtual void SignatureAttack()
    {

    }

    public void UseAttackPlayer(int _damage)
    {
        _pokemonTrainer.PV -= _damage;
        _uiManager.LifeTrainerUpdate(_damage);
    }
    public void UseAttackTrainer(int _damage)
    {
        _pokemonPlayer.PV -= _damage;
        _uiManager.LifePlayerUpdate(_damage);
    }
}
