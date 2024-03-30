using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame : MonoBehaviour
{
    [SerializeField] private GameObject _pause;

    private void Start()
    {
        
    }

    public void PauseButton()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void TryAgainButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}