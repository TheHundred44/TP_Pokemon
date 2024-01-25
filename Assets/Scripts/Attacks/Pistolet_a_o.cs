using TMPro;
using UnityEngine;

public class Pistolet_a_o : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
        _uiManager = FindAnyObjectByType<UIManager>();
        _nameOfAttack2 = GameObject.Find("Attack2Text").GetComponent<TMP_Text>();

        NameOfAttack2 = "PISTOLET A EAU";
        TypeOfAttack2 = "Eau";

        if(_pokemon.tag.Equals("PokemonPlayer"))
        {
            _nameOfAttack2.text = NameOfAttack2;
        }
    }

    public override void SignatureAttack()
    {
        Debug.Log("oui");
        _pokemon.Damage = (_pokemon.Attack * 90) / 100;
    }
}

