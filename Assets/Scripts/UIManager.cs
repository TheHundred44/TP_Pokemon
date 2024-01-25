using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //Pokemon Player
    [SerializeField]
    private TMP_Text _namePokemonPlayer;
    [SerializeField]
    private TMP_Text _hPPokemonPlayer;
    [SerializeField]
    private Image _spritePokemonPlayer;

    Pokemon _pokemonPlayer;
    GameObject _pokemonPlayerGameObject;
    public Slider _hPPokemonPlayerSlider;


    //Pokemon Trainer
    [SerializeField]
    private TMP_Text _namePokemonTrainer;
    [SerializeField]
    private Image _spritePokemonTrainer;

    Pokemon _pokemonTrainer;
    GameObject _pokemonTrainerGameObject;
    public Slider _hPPokemonTrainerSlider;

    void Start()
    {
        _pokemonPlayerGameObject = GameObject.FindGameObjectWithTag("PokemonPlayer");
        _pokemonPlayer = _pokemonPlayerGameObject.GetComponent<Pokemon>();

        _namePokemonPlayer.text = _pokemonPlayer.Name;
        _hPPokemonPlayer.text = ""+_pokemonPlayer.PV+"   "+_pokemonPlayer.PVMax;
        _hPPokemonPlayerSlider.maxValue = _pokemonPlayer.PVMax;
        _hPPokemonPlayerSlider.value= _pokemonPlayer.PVMax;
        _spritePokemonPlayer.sprite = _pokemonPlayer.Sprite;

        _pokemonTrainerGameObject = GameObject.FindGameObjectWithTag("PokemonTrainer");
        _pokemonTrainer = _pokemonTrainerGameObject.GetComponent<Pokemon>();

        _namePokemonTrainer.text = _pokemonTrainer.Name;
        _hPPokemonTrainerSlider.maxValue= _pokemonTrainer.PVMax;
        _hPPokemonTrainerSlider.value = _pokemonTrainer.PVMax;
        _spritePokemonTrainer.sprite = _pokemonTrainer.Sprite;
    }

    public void LifePlayerUpdate(int _damage)
    {
        _hPPokemonPlayerSlider.value -= _damage;
    }

    public void LifeTrainerUpdate(int _damage)
    {
        _hPPokemonTrainerSlider.value -= _damage;
    }

}
