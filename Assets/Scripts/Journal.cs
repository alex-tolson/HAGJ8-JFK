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
    public TMP_Text _dustRifle, _dustPaperSack, _dustReceipt, _dustBulletCasings, _dustBulletFragments;
    public TMP_Text _analyzeRifle, _analyzePaperSack, _analyzeReceipt, _analyzeBulletCasings, _analyzeBulletFragments;
    public TMP_Text _inspectRifle, _inspectPaperSack, _inspectReceipt, _inspectBulletCasings, _inspectBulletFragments;
    public float _evidenceCounter = 0;
    public float _evidenceTotal = 20;
    public TMP_Text _rank;
    public GameObject _endingPanel;

    private void Awake()
    {
        _instance = this;
    }

    public void RankPlayer()
    {
        float ratio = (_evidenceCounter / _evidenceTotal);
        if ( ratio < .25f && ratio > 0f)
        {
            _rank.text = "Rank C: The shooter escaped trial...You don't even know who the shooter is.  Do you know who you are?";
        }
        if (ratio < .5f && ratio >= 0.25f)
        {
            _rank.text = "Rank B: The shooter escaped trial...Close only counts in horseshoes and hand grenades...";
        }
        if (ratio > .5f && ratio <= .75f)
        {
            _rank.text = "Rank A: You realize you passed the shooter in the Hallway. you have enough evidence to convict him. But he can't have gone too far.";
        }
        if (ratio > .75f && ratio <= 1f)
        {
            _rank.text = "Rank S: You realize you passed the shooter in the Hallway.  You found him and he is arrested for the Assassination of John F. Kennedy.";
        }
    }
}
