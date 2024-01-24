using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public GameObject NextAnimationObject;
    

    public void PlayAnimationPokeballPlayer()
    {
        NextAnimationObject.GetComponent<Animator>().SetTrigger("PokeballPlayer");
    }

    public void PlayAnimationPokemonPlayer()
    {
        NextAnimationObject.GetComponent<Animator>().SetTrigger("PokemonPlayer");
    }

    public void PlayAnimationPokeballTrainer()
    {
        NextAnimationObject.GetComponent<Animator>().SetTrigger("PokeballTrainer");
    }

    public void PlayAnimationPokemonTrainer()
    {
        NextAnimationObject.GetComponent<Animator>().SetTrigger("PokeballTrainer");
    }

}
