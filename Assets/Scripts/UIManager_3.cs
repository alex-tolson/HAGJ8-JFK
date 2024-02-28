using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager_3 : MonoBehaviour
{
    [SerializeField] private GameObject _panelOswaldConvo;
    [SerializeField] private TMP_Text _convoTextPlayer;
    [SerializeField] private TMP_Text _convoTextOswald;
    [SerializeField] private GameObject _oswald;
    [SerializeField] private GameObject _button_next;
    [SerializeField] private GameObject _button_endConvo;
    private GameManager _gameManager;
    [SerializeField] private int _currentSceneBuildIndex;
     [SerializeField] private float _dist;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enterButton;
    [SerializeField] private GameObject _6thFloorEmpty;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        _gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
        _gameManager.OswaldIteration();
        if (_gameManager.WhatIsOswaldsIteration() > 1)
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
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _currentSceneBuildIndex = scene.buildIndex;
    }
    public void EnterButton(int SceneNumber)
    {
        //Debug.Log("unloading " + this._currentScene.name);
        SceneManager.UnloadSceneAsync(_currentSceneBuildIndex);
        //Debug.Log("Loading async " + _currentScene.name);
        SceneManager.LoadScene(SceneNumber, LoadSceneMode.Additive);
    }

    private void Update()
    {
        _dist = Vector3.Distance(_6thFloorEmpty.transform.position,_player.transform.position);
        if (_dist < 1f)
        {
            _enterButton.SetActive(true);
        }
        else
        {
            _enterButton.SetActive(false);
        }
    } 
}
