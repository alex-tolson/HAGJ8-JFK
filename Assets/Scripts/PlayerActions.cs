using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private GameObject _responsePanel;
    [SerializeField] private TMP_Text _responseText;
    [SerializeField] private GameObject _confirmEndSearchPanel;
    [SerializeField] private GameObject _playerActionsPanel;
    [SerializeField] private bool _paperSack, _bulletCasings, _receipt, _rifle;

    public void OpenPlayerActionsPanel()
    {
        _playerActionsPanel.SetActive(true);
    }
    public void ButtonSpeakPressed()
    {
        _responsePanel.SetActive(true);
        _responseText.text = "Who am I talking to... ?";
    }

    //=============================
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
    //============================
    public void PapersackSelected()
    {
        _paperSack = true;
        _bulletCasings = false;
        _receipt = false;
        _rifle = false;

    }
    public void BulletCasingselected()
    {
        _paperSack = false;
        _bulletCasings = true;
        _receipt = false;
        _rifle = false;
    }
    public void ReceiptSelected()
    {
        _paperSack = false;
        _bulletCasings = false;
        _receipt = true;
        _rifle = false;
    }
    public void RifleSelected()
    {
        _paperSack = false;
        _bulletCasings = false;
        _receipt = false;
        _rifle = true;
    }
    //=============================
    public void ButtonDust()
    {
        _responsePanel.SetActive(true);
        if (_paperSack)
        {
            _responseText.text = "There are no fingerprints on the paper sack.";
        }
        if (_bulletCasings)
        {
            _responseText.text = "There are no fingerprints on the bullet casings.";
        }
        if (_receipt)
        {
            _responseText.text = "There are fingerprints on the receipt. They match Lee Oswald in the database.";
        }
        if (_rifle)
        {
            _responseText.text = "There are no fingerprints on the rifle.";
        }
    }
    public void ButtonAnalyze()
    {
        _responsePanel.SetActive(true);
        if (_paperSack)
        {
            _responseText.text = "This papersack could have been obtained from any store.  It's generic.";
        }
        if (_bulletCasings)
        {
            _responseText.text = "They have a distinctive markings on them that match the barrel of the rifle.";
        }
        if (_receipt)
        {
            _responseText.text = "This is a fake signature.  The handwriting matches Lee Oswald.";
        }
        if (_rifle)
        {
            _responseText.text = "This barrel would have left machine markings on the bullet and casings.";
        }
    }
    public void ButtonInspect()
    {
        _responsePanel.SetActive(true);
        if (_paperSack)
        {
            _responseText.text = "It's a regular paper sack with an invoice inside.";
        }
        if (_bulletCasings)
        {
            _responseText.text = "These casings are the exact caliber of the rifle.  They came from this rifle.";

        }
        if (_receipt)
        {
            _responseText.text = "The handwriting on the receipt matches the Invoice signature for A. Haddell.";
        }
        if (_rifle)
        {
            _responseText.text = "This is a high-powered hunting rifle. Just like the eyewitness described.";    
        }
    }
}

