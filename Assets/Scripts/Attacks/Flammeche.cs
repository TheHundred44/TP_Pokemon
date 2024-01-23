using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flammeche : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
        _uiManager = FindAnyObjectByType<UIManager>();
        _nameOfAttack2 = GameObject.Find("Attack2Text").GetComponent<TMP_Text>();

        NameOfAttack2 = "FLAMMECHE";
        TypeOfAttack2 = "Feu";
        if (_pokemon.tag.Equals("Player"))
        {
            _nameOfAttack2.text = NameOfAttack2;
        }
    }

    public override void SignatureAttack()
    {
        _pokemon.Damage = _pokemon.Attack;
    }
}
