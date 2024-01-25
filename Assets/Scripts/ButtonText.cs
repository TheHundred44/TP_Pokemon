using UnityEngine;
using TMPro;

public class ButtonText : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    private void Start()
    {
        text.text = "Veuillez choisir une action a effectuer.";

    }

    public void FightButton()
    {
        text.text = "Choissez une attaque.";
    }

    public void HealthButton()
    {
        text.text = "Choisir une action que Pierre doit effectuer.";
    }

    public void PokemonButton()
    {
        text.text = "Choissiez un Pokemon a echanger.";
    }

    public void RunButton()
    {
        text.text = "Vous ne pouvez pas fuir un combat contre un dresseur.";
    }

    public void ReturnButton() 
    {
        text.text = "Veuillez choisir une action a effectuer.";
    }
}
