using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flammeche : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();

        NameOfAttack2 = "Flamm�che";
        TypeOfAttack2 = "Feu";
    }

    public override void SignatureAttack()
    {
        _pokemon.Damage = _pokemon.Attack;
    }
}
