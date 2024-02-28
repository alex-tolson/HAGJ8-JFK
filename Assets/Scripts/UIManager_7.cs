using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager_7 : MonoBehaviour
{
    [SerializeField] private GameObject _responsePanel;
    [SerializeField] private TMP_Text _responseText;
    [SerializeField] private GameObject _confirmEndSearchPanel;
    [SerializeField] private GameObject _playerActionsPanel;

    public void OpenPlayerActionsPanel()
    {
        _playerActionsPanel.SetActive(true);
    }
    public void OpenResponsePanel()
    {
        _responsePanel.SetActive(true);
    }
    //-------------------------------------
    public void ButtonEndSearchPressed()
    {
        _confirmEndSearchPanel.SetActive(true);
    }
    public void RecordInfo()
    {
        Debug.Log("Information recorded");

    }
    public void CloseResponsePanel()
    {
        _responsePanel.SetActive(false);
    }
    public void EndingInvestigation()
    {
        //work up how the win and lose are tallied;
        Debug.Log("spit out response on Win/Lose screen");
        //SceneManager.LoadScene(8);
    }
    public void DoNOTEndInvestigation()
    {
        //closeConfirmEndSearch Panel
        _confirmEndSearchPanel.SetActive(false);
    }
    //-------------------------------------
    public void ButtonSpeak()
    {
        _responseText.text = "Who am I talking to...?";
    }
    public void ButtonDust()
    {
        _responseText.text = "You don't see any fingerprints on these bullet fragments.";
        Journal.Instance._dustBulletFragments.text = _responseText.text;
        Journal.Instance._evidenceCounter++;
    }
    public void ButtonAnalyze()
    {
        _responseText.text = "If we can find the barrel that made these markings on the bullet fragments, we'll have found our weapon.";
        Journal.Instance._analyzeBulletFragments.text = _responseText.text;
        Journal.Instance._evidenceCounter++;
    }
    public void ButtonInspect()
    {
        _responseText.text = "If we can match these to the shell casings and the rifle, we'll have found our weapon.";
        Journal.Instance._inspectBulletFragments.text = _responseText.text;
        Journal.Instance._evidenceCounter++;
    }
}
