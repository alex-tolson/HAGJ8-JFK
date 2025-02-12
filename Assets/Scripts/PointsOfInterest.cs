using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsOfInterest : MonoBehaviour
{

    [SerializeField] private GameObject _poiCartonsPhysicalLocation, _poiPaperSack, _poiBulletCasings, _poiReceipt, _poiRifle,
        _poiCartons, _playerActions;
    //[SerializeField] private float _distance;
    [SerializeField] private GameObject _player;
    private AudioManager _audioManager;
    //[SerializeField] private float _fadeawaySpeed;
    [SerializeField] private GameObject _cartons;
    //[SerializeField] private Color _cartonsAlpha;

    void Start()
    {
        _audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        if(_audioManager==null)
        {
            Debug.LogError("PointsOfInterest::AudioManager is null");
        }
    }


    public void CartonsFadeAway()
    {
        //while (_cartonsAlpha.a > 0.0f)
        //{
        //    _cartonsAlpha.a -= ((100 / _fadeawaySpeed) * Time.deltaTime);
        //}
        _cartons.SetActive(false);
        _poiCartons.SetActive(false);
        _poiPaperSack.SetActive(true);
        _poiBulletCasings.SetActive(true);
        _poiReceipt.SetActive(true);
        _poiRifle.SetActive(true);
    }

    public void ActivatePlayerActions()
    {
        _playerActions.SetActive(true);
    }
}
