using TMPro;
using UnityEngine;

public class Soin : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
        _uiManager = FindAnyObjectByType<UIManager>(); 
        _nameOfAttack2 = GameObject.Find("Attack2Text").GetComponent<TMP_Text>();

        NameOfAttack2 = "SOIN";
        TypeOfAttack2 = "Plante";

        if (_pokemon.tag.Equals("PokemonPlayer"))
        {
            _nameOfAttack2.text = NameOfAttack2;
        }
    }

    public override void SignatureAttack()
    {
        _pokemon.Damage = 0;
        _pokemon.PV += 30;

        if (_pokemon.PV >= _pokemon.PVMax)
        {
            _pokemon.PV = _pokemon.PVMax;
        }
    }
}

