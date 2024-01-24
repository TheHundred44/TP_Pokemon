using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public GameObject PokeballTrainer;
    public GameObject PokeballPlayer;
    public GameObject Player;
    public GameObject Trainer;

    public void PlayAnimation2()
    {
        PokeballPlayer.GetComponent<Animation>().Play("PokeballPlayer");
    }

    public void PlayAnimation3()
    {
        Player.GetComponent<Animation>().Play("PokemonPlayer");
    }

    public void PlayAnimation4()
    {
        Trainer.GetComponent<Animation>().Play("PokeballTrainer");
    }

    public void PlayAnimation5()
    {
        PokeballTrainer.GetComponent<Animation>().Play("PokeballTrainer");
    }

}
