using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Canvas _uiIntro;
    private Canvas _uiInstructions;
    private GameObject _creditsPanel;
    [SerializeField] private int _currentSceneBuildIndex;
    [SerializeField] private int _iteration;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void Start()
    {
        
        _uiIntro = GameObject.Find("UI_Intro").GetComponent<Canvas>();
        _uiInstructions = GameObject.Find("CanvasPage1").GetComponent<Canvas>();
        if (_uiIntro == null)
        {
            Debug.Log("GameManager::UI_Intro is null");
        }
        _uiInstructions = GameObject.Find("CanvasPage1").GetComponent<Canvas>();
        if (_uiInstructions != null)
        {
            _uiInstructions.gameObject.SetActive(false);
        }
    }
    public void BeginGame()
    {
        _uiIntro.gameObject.SetActive(false);
        _uiInstructions.gameObject.SetActive(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void SceneToInstructions()
    {
        _uiIntro.gameObject.SetActive(false);
        _uiInstructions.gameObject.SetActive(true);
    }
    public void CreditsScene()
    {
        _uiIntro.gameObject.SetActive(false);
        _uiInstructions.gameObject.SetActive(false);
        _creditsPanel.SetActive(true);
    }
    public void BackToIntro()
    {
        _uiIntro.gameObject.SetActive(true);
        _uiInstructions.gameObject.SetActive(false);
        _creditsPanel.SetActive(false);
    }

    public void BackButton(int SceneNumber)
    {
        //Debug.Log("unloading " + this._currentScene.name);
        SceneManager.UnloadSceneAsync(_currentSceneBuildIndex);
        //Debug.Log("Loading async " + _currentScene.name);
        SceneManager.LoadScene(SceneNumber, LoadSceneMode.Additive);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _currentSceneBuildIndex = scene.buildIndex;
    }

    public void OswaldIteration()
    {
        _iteration++;
    }
    public int WhatIsOswaldsIteration()
    {
        return _iteration;
    }
    public void CloseInvestigation()
    {
        SceneManager.UnloadSceneAsync(_currentSceneBuildIndex);
        Journal.Instance._endingPanel.SetActive(true);
        Journal.Instance.RankPlayer();
    }
}
