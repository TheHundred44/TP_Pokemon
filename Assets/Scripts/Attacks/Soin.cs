using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soin : Attacks
{
    public override void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();

        NameOfAttack2 = "Soin";
        TypeOfAttack2 = "Plante";
    }

    public override void SignatureAttack()
    {
        _pokemon.PV += 30;

        if (_pokemon.PV >= _pokemon.PVMax)
        {
            _pokemon.PV = _pokemon.PVMax;
        }
    }
}

