using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleManager : MonoBehaviour
{
    Pokemon _pokemonPlayer;
    Pokemon _pokemonTrainer;

    Humain _humainTrainer;
    public  Humain _humainPlayer;

    public GameObject PlayerPokemonGameObject;
    GameObject _trainerPokemonGameObject;

    public Attacks _attacks;

    public GameObject LoseScreen;
    public TMP_Text TextLose;

    private bool _canContinued;

    private void Awake()
    {
        PlayerPokemonGameObject = GameObject.FindGameObjectWithTag("PokemonPlayer");
        _pokemonPlayer = PlayerPokemonGameObject.GetComponent<Pokemon>();
        _humainPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Humain>();

        _trainerPokemonGameObject = GameObject.FindGameObjectWithTag("PokemonTrainer");
        _pokemonTrainer = _trainerPokemonGameObject.GetComponent<Pokemon>();
        _humainTrainer = GameObject.FindGameObjectWithTag("Trainer").GetComponent<Humain>();

    }

    public void BattleStart()
    {
        if(_pokemonPlayer.Speed > _pokemonTrainer.Speed)
        {
            _attacks.UseAttackPlayer(_pokemonPlayer.Damage);
            _canContinued = VerificationLife(_pokemonTrainer.PV, _humainTrainer);

            _attacks.UseAttackPlayer(_pokemonPlayer.Damage);
            VerificationLife(_pokemonTrainer.PV, _humainTrainer);
            {
                ChoiceAttackIA();
                _attacks.UseAttackTrainer(_pokemonTrainer.Damage);
                VerificationLife(_pokemonPlayer.PV, _humainPlayer);
            }

        }
        else if (_pokemonTrainer.Speed > _pokemonPlayer.Speed)
        {
            ChoiceAttackIA();
            _attacks.UseAttackTrainer(_pokemonTrainer.Damage);
            _canContinued = VerificationLife(_pokemonPlayer.PV, _humainPlayer);

            if (_canContinued)
            {
                _attacks.UseAttackPlayer(_pokemonPlayer.Damage);
                VerificationLife(_pokemonTrainer.PV, _humainTrainer);
            }

        }
        else
        {
            int nombreAleatoire = Random.Range(1, 2);

            if (nombreAleatoire == 1)
            {
                _attacks.UseAttackPlayer(_pokemonPlayer.Damage);
                _canContinued = VerificationLife(_pokemonTrainer.PV, _humainTrainer);

                if (_canContinued)
                {
                    ChoiceAttackIA();
                    _attacks.UseAttackTrainer(_pokemonTrainer.Damage);
                    VerificationLife(_pokemonPlayer.PV, _humainPlayer);
                }

            }
            else
            {
                ChoiceAttackIA();
                _attacks.UseAttackTrainer(_pokemonTrainer.Damage);
                _canContinued = VerificationLife(_pokemonPlayer.PV, _humainTrainer);

                if (_canContinued)
                {
                    _attacks.UseAttackPlayer(_pokemonPlayer.Damage);
                    VerificationLife(_pokemonTrainer.PV, _humainPlayer);
                }
                
            }
        }
    }

    public bool VerificationLife(int life, Humain _humain)
    {
        if (life < 0)
        {
            if(_humain.ListPokemon.Count > 0)
            {
                _humain.ListPokemon.RemoveAt(0);

                if(_humain.tag == "Player")
                {
                    _humain.ListPokemon[0].tag = "PlayerPokemon";
                }

                else
                {
                    _humain.ListPokemon[0].tag = "TrainerPokemon";
                }
            }
            else
            {
                TextLose.text = _humain.name + "a perdu";
            }

            return false;
        }
        else return true;
    }

    public void ChoiceAttackIA()
    {
        int nombreAleatoire = Random.Range(1, 2);

        if (nombreAleatoire == 1)
        {
            _attacks.Charge(_trainerPokemonGameObject);
        }

        else
        {
            _attacks.SignatureAttack();
        }
    }
}
