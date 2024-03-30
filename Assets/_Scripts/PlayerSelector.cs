using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    [SerializeField] private GameObject flag;

    private void Start()
    {
        string num = PlayerPrefs.GetInt("planeNum", 0).ToString();
        if (num == gameObject.name)
        {
            PickPlayer();
        }
    }

    public void PickPlayer()
    {
        flag.transform.SetParent(transform, false);
        PlayerPrefs.SetInt("planeNum", int.Parse(gameObject.name));
    }
}
