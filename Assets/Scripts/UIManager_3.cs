using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager_3 : MonoBehaviour
{
    [SerializeField] private GameObject _panelOswaldConvo;
    [SerializeField] private TMP_Text _convoTextPlayer;
    [SerializeField] private TMP_Text _convoTextOswald;
    private int _iteration = 0;
    [SerializeField] private GameObject _oswald;
    [SerializeField] private GameObject _button_next;
    [SerializeField] private GameObject _button_endConvo;
    //private Scene _currentScene;
    //[SerializeField] private int _currentSceneBuildIndex;

 
    private void OnEnable()
    {
            //SceneManager.sceneLoaded += OnSceneLoaded;
        
        _iteration++;

        if (_iteration > 1)
        {
            _oswald.SetActive(false);
        }
        else 
        {
            _oswald.SetActive(true);
        }
    }//Oswald only appears the first time we go the TexasDepo 6th floor

    public void ActivateOswaldConvo()
    {
        _panelOswaldConvo.SetActive(true);
        _convoTextPlayer.text = "What are you doing up here?!";
        _convoTextOswald.text = "I work here...";
    }

    public bool OswaldConvoPanel()
    {
        return _panelOswaldConvo.activeInHierarchy;
    }
    public void DeactivateOswaldConvo()
    {
        _panelOswaldConvo.SetActive(false);
    }
    public void NextButton()
    {
        _convoTextPlayer.text = "Okay, I'm looking for a shooter. Someone shot the President.";
        _convoTextOswald.text = "I haven't seen anyone. Sorry.";
        _button_endConvo.SetActive(true);
        _button_next.SetActive(false);
    }

    //private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    _currentSceneBuildIndex = scene.buildIndex;
    //}
}
