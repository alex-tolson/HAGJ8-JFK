using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Oswald : MonoBehaviour
{
    private UIManager_3 _uiManager_3;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _doorFrame;
    [SerializeField] private GameObject _doorframeEmpty;
    private float _dist;
    private Animator _anim;

    void Start()
    {
        _uiManager_3 = GameObject.Find("UIManager_3").GetComponent<UIManager_3>();
        if (_uiManager_3 == null)
        {
            Debug.LogError("Oswald::UImanager is null");
        }
        _doorFrame = _doorframeEmpty.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.CompareTag("Player"))
        {
            _uiManager_3.ActivateOswaldConvo();
        }
    }
    private void Update()
    {
        _dist = Vector3.Distance(_doorFrame, transform.position);
        if (_uiManager_3.OswaldConvoPanel())
        {
            _anim.SetBool("Walking", false);
        }
        else
        {
            _anim.SetBool("Walking", true);
            OswaldMov();
        }   
        if (_dist < 0.05f)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void OswaldMov()
    {
        transform.position = Vector3.MoveTowards(transform.position, _doorFrame, _speed * Time.deltaTime);
    }

    
}
