using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreTime : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeScoreText;
    private float _score = 0;
    private float _bestScore;

    private void Start()
    {
        _bestScore = PlayerPrefs.GetFloat("bestScore", 0);
    }

    private void Update()
    {
        _score = _score + 1 * Time.deltaTime;
        if (_score >= _bestScore)
        {
            _bestScore = _score;
        }
        _timeScoreText.text = _score.ToString("f2");
    }
}