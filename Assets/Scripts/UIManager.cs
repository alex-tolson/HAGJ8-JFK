using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite _select, _texDepo, _newCourt, _oldCourt, _reagansRoute;
    [SerializeField] SpriteRenderer _scene1_Select;
    [SerializeField] GameObject _confirmChoicePanel, _playerActions, _confirmEndSearchPanel;
    [SerializeField] private bool _questionEyeWitness, _crowd1, _crowd2, _crowd3, _crowd4;

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
        if (_crowd1 == true)
        {
            Debug.Log("It sounded like a high powered hunting rifle");
        }
        if (_crowd2 == true)
        {
            Debug.Log("I saw someone in the window of the Texas Schoolbook Depository building");
        }
        if (_crowd3 == true)
        {
            Debug.Log("Male, White shirt.  5 feet 10 inches, 160 lbs.");
        }
        if (_crowd4 == true)
        {
            Debug.Log("I can't believe this!");
        }
    }

    public void ButtonDustPressed()
    {
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            Debug.Log("Are you crazy! I can't fingerprint all these people!");
        }
    }
    public void ButtonAnalyzePressed()
    {
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            Debug.Log("I don't have any information to Analyze...");
        }
    }

    public void ButtonInspectPressed()
    {
        if (_crowd1 || _crowd2 || _crowd3 || _crowd4)
        {
            Debug.Log("I don't have anything to inspect right now.");
        }
    }
    public void ButtonEndSearchPressed()
    {
        _confirmEndSearchPanel.SetActive(true);
    }


}