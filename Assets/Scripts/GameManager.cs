using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> ListHuman;
    public GameObject Player;
    public GameObject Trainer;
    public int NBTrainer;

    public List<Sprite> ListSpritesTerrain;
    public Image SpriteTerrain;
    public int NBTerrain;

    public void Awake()
    {
        AttributionTrainer();
        AttributionTerrain();
    }
    public void AttributionTrainer()
    {
        if (ListHuman.Count >= NBTrainer)
        {
            
            GameObject _humainAleatoire = HumanRandom();
            Player = _humainAleatoire;
            Debug.Log(_humainAleatoire);
            Debug.Log(Player);

            GameObject _humainAleatoire2 = HumanRandom();
            Trainer = _humainAleatoire2;

        }
        else
        {
            Debug.LogError("La liste des humains disponibles est insuffisante.");
        }
    }

    GameObject HumanRandom()
    {
        return ListHuman[Random.Range(0, ListHuman.Count)];
    }

    public void AttributionTerrain()
    {
        if (ListHuman.Count >= NBTerrain)
        {

            Sprite _terrainAleatoire = TerrainRandom();
            SpriteTerrain.sprite = _terrainAleatoire;


        }
        else
        {
            Debug.LogError("La liste des humains disponibles est insuffisante.");
        }
    }

    Sprite TerrainRandom()
    {
        return ListSpritesTerrain[Random.Range(0, ListSpritesTerrain.Count)];
    }


}
