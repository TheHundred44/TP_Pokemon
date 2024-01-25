using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Human", menuName = "Create Human")]
public class HumainScriptable : ScriptableObject
{
    public string NameTrainer;
    public List<Pokemon> ListPokemon;
    public int NbPokemon;
    public Sprite SpriteHuman;
}
