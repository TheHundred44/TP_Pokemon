using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    protected Pokemon _pokemon;

    public string NameOfAttack = "Charge";
    public string TypeOfAttack = "Normal";

    public string NameOfAttack2;
    public string TypeOfAttack2;

    public virtual void Start()
    {
        _pokemon = FindObjectOfType<Pokemon>();
    }

    public void Charge()
    {
        _pokemon.Damage = (_pokemon.Attack * 20) / 100;
    }

    public virtual void SignatureAttack()
    {

    }
}
