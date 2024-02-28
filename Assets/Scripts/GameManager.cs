using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _introPanel;
    private Canvas _uiInstructions;
    [SerializeField] private int _currentSceneBuildIndex;
    private Scene _currentScene;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void Start()
    {
        
        _uiInstructions = GameObject.Find("CanvasPage1").GetComponent<Canvas>();
        if (_uiInstructions != null)
        { 
            _uiInstructions.gameObject.SetActive(false); 
        }
    }
    public void BeginGame()
    {
        _introPanel.SetActive(false);
        _uiInstructions.gameObject.SetActive(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void SceneToInstructions()
    {
        _introPanel.SetActive(false);
        _uiInstructions.gameObject.SetActive(true);
    }

    public void BackButton(int SceneNumber)
    {
        Debug.Log("unloading " + this._currentScene.name);
        SceneManager.UnloadSceneAsync(_currentSceneBuildIndex);
        Debug.Log("Loading async " + _currentScene.name);
        SceneManager.LoadScene(SceneNumber, LoadSceneMode.Additive);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _currentSceneBuildIndex = scene.buildIndex;
    }
}
