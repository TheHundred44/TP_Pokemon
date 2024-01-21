using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Create Pokemon")]
public class PokemonScriptable : ScriptableObject
{
        public Sprite Sprite;
        public string Name;
        public int PV;
        public int Attack;
        public int Defence;
        public int Speed;
        public string Type;
    }
