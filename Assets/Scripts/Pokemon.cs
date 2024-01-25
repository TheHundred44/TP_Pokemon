using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public PokemonScriptable PokemonScriptable;

    public Sprite Sprite;
    public string Name;
    public int PV;
    public int Attack;
    public int Defence;
    public int Speed;
    public string Type;

    public int Damage;
    public int PVMax;

    void Awake()
    {
        Sprite = PokemonScriptable.Sprite;
        Name = PokemonScriptable.Name;
        PV = PokemonScriptable.PV;
        Attack = PokemonScriptable.Attack;
        Defence = PokemonScriptable.Defence;
        Speed = PokemonScriptable.Speed;
        Type = PokemonScriptable.Type;

        PVMax = PV;
    }
}
