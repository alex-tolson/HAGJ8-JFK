using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private GameObject _responsePanel;
    [SerializeField] private TMP_Text _responseText;
    [SerializeField] private GameObject _confirmEndSearchPanel;
    [SerializeField]


    public void ButtonSpeakPressed()
    {
        _responsePanel.SetActive(true);

    }

    public void ButtonDustPressed()
    {
        _responsePanel.SetActive(true);
        //if ()
        //{
        //    _responseText.text = "Are you crazy! I can't fingerprint all these people!";
        //}
    }
    public void ButtonAnalyzePressed()
    {
        _responsePanel.SetActive(true);
        //if ()
        //{
        //    _responseText.text = "I don't have any information to Analyze...";
        //}
    }

    public void ButtonInspectPressed()
    {
        _responsePanel.SetActive(true);
        //if ()
        //{
        //    _responseText.text = "I don't have anything to inspect right now.";
        //}
    }
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
}

