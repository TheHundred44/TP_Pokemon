using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public GameObject NextAnimationObject;
    

    public void PlayAnimationPokeballPlayer()
    {
        NextAnimationObject.GetComponent<Animation>().Play("PokeballPlayer");
    }

    public void PlayAnimationPokemonPlayer()
    {
        NextAnimationObject.GetComponent<Animation>().Play("PokemonPlayer");
    }

    public void PlayAnimationPokeballTrainer()
    {
        NextAnimationObject.GetComponent<Animation>().Play("PokeballTrainer");
    }

    public void PlayAnimationPokemonTrainer()
    {
        NextAnimationObject.GetComponent<Animation>().Play("PokeballTrainer");
    }

}
