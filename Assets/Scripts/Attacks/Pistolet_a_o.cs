using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolet_a_o : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
        _uiManager = FindAnyObjectByType<UIManager>();

        NameOfAttack2 = "Pistolet à O";
        TypeOfAttack2 = "Eau";
    }

    public override void SignatureAttack()
    {
        _pokemon.Damage = (_pokemon.Attack * 90) / 100;
    }
}

