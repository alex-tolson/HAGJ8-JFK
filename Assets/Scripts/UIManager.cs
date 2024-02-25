using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite _select, _texDepo, _newCourt, _oldCourt, _reagansRoute;

    [SerializeField] SpriteRenderer _scene1_Select;

    [SerializeField] GameObject _confirmChoicePanel, _playerActions, _confirmEndSearchPanel, _responsePanel;

    [SerializeField] private bool _questionEyeWitness, _crowd1, _crowd2, _crowd3, _crowd4;

    [SerializeField] private TMP_Text _responseText;

    public void SelectTexDepo()
    {
        _scene1_Select.sprite = _texDepo;
        _confirmChoicePanel.SetActive(true);
        _playerActions.SetActive(false);
    }
    public void SelectnewCourt()
    {
        _scene1_Select.sprite = _newCourt;
        _confirmChoicePanel.SetActive(true);
        _playerActions.SetActive(false);
    }
    public void SelectoldCourt()
    {
        _scene1_Select.sprite = _oldCourt;
        _confirmChoicePanel.SetActive(true);
        _playerActions.SetActive(false);
    }
    public void SelectBuilding()
    {
        _scene1_Select.sprite = _select;
        _confirmChoicePanel.SetActive(true);
        _playerActions.SetActive(false);
    }
    public void SelectCarSearch()
    {
        _scene1_Select.sprite = _reagansRoute;
        _confirmChoicePanel.SetActive(true);
        _playerActions.SetActive(false);
    }
    public void LoadNextScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ConfirmSelection()
    {
        Debug.Log("Load next scene");
        WhichSceneLoading();
    }

    private void WhichSceneLoading()
    {
        if (_scene1_Select.sprite == _texDepo)
        {
            //return 4
            //_selectionPanel.SetActive(false);
            Debug.Log("loading texas depository");
        }
        if (_scene1_Select.sprite == _newCourt)
        {
            //return 6
            //_selectionPanel.SetActive(false);
            Debug.Log("loading new Court house");
        }
        if (_scene1_Select.sprite == _oldCourt)
        {
            //return 7
            //_selectionPanel.SetActive(false);
            Debug.Log("loading old court house");
        }
        if (_scene1_Select.sprite == _reagansRoute)
        {
            //return 8
            //_selectionPanel.SetActive(false);
            Debug.Log("loading car scene");
        }
    }

    public void ChangeSelection()
    {
        _scene1_Select.sprite =_select;
        _confirmChoicePanel.SetActive(false);
        _confirmEndSearchPanel.SetActive(false);
        _crowd1 = false;
        _crowd2 = false;
        _crowd3 = false;
        _crowd4 = false;

    }

    public void ActionToCrowd1()
    {
        Debug.Log("clicked on crowd 1");
        _crowd1 = true;
        _crowd2 = false;
        _crowd3 = false;
        _crowd4 = false;
        _playerActions.SetActive(true);
    }
    public void ActionToCrowd2()
    {
        Debug.Log("clicked on crowd 2");
        _crowd1 = false;
        _crowd2 = true;
        _crowd3 = false;
        _crowd4 = false;
        _playerActions.SetActive(true);

        
    }
    public void ActionToCrowd3()
    {
        Debug.Log("clicked on crowd 3");
        _crowd1 = false;
        _crowd2 = false;
        _crowd3 = true;
        _crowd4 = false;
        _playerActions.SetActive(true);
    }
    public void ActionToCrowd4()
    {
        Debug.Log("clicked on crowd 4");
        _crowd1 = false;
        _crowd2 = false;
        _crowd3 = false;
        _crowd4 = true;
        _playerActions.SetActive(true);
    }

    public void ButtonSpeakPressed()
    {
        _responsePanel.SetActive(true);
        if (_crowd1 == true)
        {
            _responseText.text = "It sounded like a high powered hunting rifle";
        }
        if (_crowd2 == true)
        {
            _responseText.text = "I saw someone in the window of the Texas Schoolbook Depository building";
        }
        if (_crowd3 == true)
        {
            _responseText.text = "Male, White shirt.  5 feet 10 inches, 160 lbs.";
        }
        if (_crowd4 == true)
        {
            _responseText.text = "I heard 3 shots!";
        }
    }

    public void ButtonDustPressed()
    {
        _responsePanel.SetActive(true);
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            _responseText.text = "Are you crazy! I can't fingerprint all these people!";
        }
    }
    public void ButtonAnalyzePressed()
    {
        _responsePanel.SetActive(true);
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            _responseText.text = "I don't have any information to Analyze...";
        }
    }

    public void ButtonInspectPressed()
    {
        _responsePanel.SetActive(true);
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            _responseText.text = "I don't have anything to inspect right now.";
        }
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

}