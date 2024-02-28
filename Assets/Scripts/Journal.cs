using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Journal : MonoBehaviour
{


    private static Journal _instance;
    public static Journal Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Journal is null");
            }
            return _instance;
        }
    }
    public TMP_Text _textCrowd1, _textCrowd2, _textCrowd3, _textCrowd4;

    private void Awake()
    {
        _instance = this;
    }


}
