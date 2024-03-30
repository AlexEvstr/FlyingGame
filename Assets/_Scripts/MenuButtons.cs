using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _soundOn;
    [SerializeField] private GameObject _soundOff;

    private float _sound = 1;

    private void Start()
    {
        _sound = PlayerPrefs.GetFloat("sound", 1);
        if (_sound == 1)
        {
            TurnOnSound();
        }
        else
        {
            TurnOffSound();
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void TurnOffSound()
    {
        _soundOn.SetActive(false);
        _soundOff.SetActive(true);
        _sound = 0;
        PlayerPrefs.SetFloat("sound", _sound);
    }

    public void TurnOnSound()
    {
        _soundOn.SetActive(true);
        _soundOff.SetActive(false);
        _sound = 1;
        PlayerPrefs.SetFloat("sound", _sound);
    }

    private void Update()
    {
        AudioListener.volume = _sound;
    }
}