using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //Pokemon Player
    [SerializeField]
    private TMP_Text _namePokemonPlayer;
    [SerializeField]
    private TMP_Text _hPPokemonPlayer;
    [SerializeField]
    private Image _spritePokemonPlayer;

    Pokemon _pokemonPlayer;
    GameObject _pokemonPlayerGameObject;


    //Pokemon Trainer
    [SerializeField]
    private TMP_Text _namePokemonTrainer;
    [SerializeField]
    private TMP_Text _hPPokemonTrainer;
    [SerializeField]
    private Image _spritePokemonTrainer;

    Pokemon _pokemonTrainer;
    GameObject _pokemonTrainerGameObject;


    void Start()
    {
        _pokemonPlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        _pokemonPlayer = _pokemonPlayerGameObject.GetComponent<Pokemon>();

        _namePokemonPlayer.text = _pokemonPlayer.Name;
        _hPPokemonPlayer.text = "HP : "+_pokemonPlayer.PV+"/"+_pokemonPlayer.PVMax;
        _spritePokemonPlayer.sprite = _pokemonPlayer.Sprite;

        _pokemonTrainerGameObject = GameObject.FindGameObjectWithTag("Enemy");
        _pokemonTrainer = _pokemonTrainerGameObject.GetComponent<Pokemon>();

        _namePokemonTrainer.text = _pokemonTrainer.Name;
        _hPPokemonTrainer.text = "HP : " + _pokemonTrainer.PV + "/" + _pokemonTrainer.PVMax;
        _spritePokemonTrainer.sprite = _pokemonTrainer.Sprite;
    }

}
