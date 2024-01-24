using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> ListHuman;
    public GameObject Player;
    private Humain _humainPlayer;

    public GameObject Trainer;
    public int NBTrainer;
    private Humain _humainTrainer;
    private Image _spritePlayer;

    public List<Sprite> ListSpritesTerrain;
    public Image SpriteTerrain;
    public int NBTerrain;
    private Image _spriteTrainer;

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
            Humain _playerRandom = _humainAleatoire.GetComponent<Humain>();

            _spritePlayer = Player.GetComponent<Image>();

            _humainPlayer = Player.GetComponent<Humain>();
            _humainPlayer.humainScriptable = _playerRandom.humainScriptable;
            _humainPlayer.NameTrainer = _playerRandom.humainScriptable.NameTrainer;
            _humainPlayer.ListPokemon = _playerRandom.humainScriptable.ListPokemon;
            _humainPlayer.NBPokemonWanted = _playerRandom.NBPokemonWanted;
            _humainPlayer.TeamPokemon = _playerRandom.TeamPokemon;
            _humainPlayer.Sprite = _playerRandom.humainScriptable.SpriteHuman;
            _spritePlayer.sprite = _humainPlayer.Sprite;


            GameObject _humainAleatoire2 = HumanRandom();
            Humain _trainerRandom = _humainAleatoire2.GetComponent<Humain>();

            _spriteTrainer = Trainer.GetComponent<Image>();

            _humainTrainer = Trainer.GetComponent<Humain>();
            _humainTrainer.humainScriptable = _trainerRandom.humainScriptable;
            _humainTrainer.NameTrainer = _trainerRandom.humainScriptable.NameTrainer;
            _humainTrainer.ListPokemon = _trainerRandom.humainScriptable.ListPokemon;
            _humainTrainer.NBPokemonWanted = _trainerRandom.NBPokemonWanted;
            _humainTrainer.TeamPokemon = _trainerRandom.TeamPokemon;
            _humainTrainer.Sprite = _trainerRandom.humainScriptable.SpriteHuman;
            _spriteTrainer.sprite = _humainTrainer.Sprite;

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
