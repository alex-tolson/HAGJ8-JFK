using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    //public void EndingInvestigation()
    //{
    //    Journal.Instance.RankPlayer();
    //    Journal.Instance._endingPanel.SetActive(true);
    //}
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
            Journal.Instance._dustPaperSack.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_bulletCasings)
        {
            _responseText.text = "There are no fingerprints on the bullet casings.";
            Journal.Instance._dustBulletCasings.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_receipt)
        {
            _responseText.text = "There are fingerprints on the receipt. They match Lee Oswald in the database.";
            Journal.Instance._dustReceipt.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_rifle)
        {
            _responseText.text = "There are no fingerprints on the rifle.";
            Journal.Instance._dustRifle.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
    }
    //---------------------------
    public void ButtonAnalyze()
    {
        _responsePanel.SetActive(true);
        if (_paperSack)
        {
            _responseText.text = "This papersack could have been obtained from any store.  It's generic.";
            Journal.Instance._analyzePaperSack.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_bulletCasings)
        {
            _responseText.text = "They have a distinctive markings on them that match the barrel of the rifle.";
            Journal.Instance._analyzeBulletCasings.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_receipt)
        {
            _responseText.text = "This is a fake signature.  The handwriting matches Lee Oswald.";
            Journal.Instance._analyzeReceipt.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_rifle)
        {
            _responseText.text = "This barrel would have left machine markings on the bullet and casings.";
            Journal.Instance._analyzeRifle.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
    }
    //---------------------------
    public void ButtonInspect()
    {
        _responsePanel.SetActive(true);
        if (_paperSack)
        {
            _responseText.text = "It's a regular paper sack with an invoice inside.";
            Journal.Instance._inspectPaperSack.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_bulletCasings)
        {
            _responseText.text = "These casings are the exact caliber of the rifle.  They came from this rifle.";
            Journal.Instance._inspectBulletCasings.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_receipt)
        {
            _responseText.text = "The handwriting on the receipt matches the Invoice signature for A. Haddell.";
            Journal.Instance._inspectReceipt.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
        if (_rifle)
        {
            _responseText.text = "This is a high-powered hunting rifle. Just like the eyewitness described.";
            Journal.Instance._inspectRifle.text = _responseText.text;
            Journal.Instance._evidenceCounter++;
        }
    }
    //---------------------------
}

