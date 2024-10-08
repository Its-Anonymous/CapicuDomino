using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;


    [Header("UI Scene Sources")]
    public AudioClip DistantVoices;
    public AudioClip El_Inicio;
    public AudioClip En_Seguida;
    public AudioClip La_Partida;
    public AudioClip Venezolano;


    [Header("UI Scene Sources")]
    public AudioSource menuMusicSource;
    public AudioSource buttonPressSource;
    public AudioSource selectModeSource;

    [Header("Game Scene Sources")]
    public AudioSource gameplayBGSource;
    public AudioSource pointsSource;
    public AudioSource camViewSource;
    public AudioSource dominoDistributionSource;
    public AudioSource boneyardSource;
    public AudioSource placetileSource;
    public AudioSource shoeMakerSource;


    public static bool _soundIsOn = true;
    public static bool _musicIsOn = true;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    //private void Start()
    //{
    //    MenuBGPlayer(true);
    //}

    public void MenuBGPlayer(bool enabled)
    {

        if (enabled)
        {
            instance.gameplayBGSource.Stop();
            instance.menuMusicSource.Play();
        }
        else
        {
            instance.gameplayBGSource.Play();
            instance.menuMusicSource.Stop();
        }
    }

    public  void ButtonPressPlayer(bool enabled)
    {
        if (enabled) instance.buttonPressSource.Play();
    }


    public  void ShoeMakerSound(bool enabled)
    {
        if (enabled) instance.shoeMakerSource.Play();
    }

    public  void SelectModePlayer(bool enabled)
    {
        if (enabled) instance.selectModeSource.Play();
    }

    public void GameplayBGPlayer(bool enabled)
    {
        if (enabled)
        {
            instance.menuMusicSource.Stop();
            instance.gameplayBGSource.Play();
        }
        else
        {
            instance.menuMusicSource.Play();
            instance.gameplayBGSource.Stop();
        }
    }

    public  void PointsAudioPlayer(bool enabled)
    {
        if (enabled) instance.pointsSource.Play();
    }

    public  void CameraButtonPlayer(bool enabled)
    {
        if (enabled) instance.camViewSource.Play();        
    }

    public  void DominoDistributionPlayer(bool enabled)
    {
        if (enabled) instance.dominoDistributionSource.Play();        
    }

    public  void BoneyardAudioPlayer(bool enabled)
    {
        if (enabled) instance.boneyardSource.Play();
    }

    public  void PlacetileAudioPlayer(bool enabled)
    {
        if (enabled) instance.placetileSource.Play();
    }

    public void SFXControllor(int _isOnValue)
    {
        bool isOn = _isOnValue == 1 ? true : false;

        buttonPressSource.enabled = isOn;
        selectModeSource.enabled = isOn;
        pointsSource.enabled = isOn; 
        camViewSource.enabled = isOn;
        dominoDistributionSource.enabled = isOn;
        boneyardSource.enabled = isOn;
        placetileSource.enabled = isOn;
    }

    public void MusicControllor(int _isOnValue)
    {
        bool isOn = _isOnValue == 1 ? true : false;

        menuMusicSource.enabled     = isOn;
        gameplayBGSource.enabled    = isOn;
    }
}
