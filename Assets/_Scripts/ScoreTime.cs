using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreTime : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeScoreText;
    [SerializeField] private TMP_Text _scoreGameover;
    [SerializeField] private TMP_Text _bestScoreGameover;
    [SerializeField] private TMP_Text _scorePause;
    [SerializeField] private TMP_Text _bestScorePause;

    private float _score = 0;
    private float _bestScore;

    private void Start()
    {
        Time.timeScale = 1;
        _bestScore = PlayerPrefs.GetFloat("bestScore", 0);
    }

    private void Update()
    {
        _score = _score + 1 * Time.deltaTime;
        if (_score >= _bestScore)
        {
            _bestScore = _score;
            PlayerPrefs.SetFloat("bestScore", _bestScore);
        }
        _timeScoreText.text = _score.ToString("f2");

        _scoreGameover.text = _score.ToString("f2");
        _bestScoreGameover.text = _bestScore.ToString("f2");

        _scorePause.text = _score.ToString("f2");
        _bestScorePause.text = _bestScore.ToString("f2");
    }
}