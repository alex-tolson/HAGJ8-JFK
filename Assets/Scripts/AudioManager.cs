using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip _click;
    [SerializeField] private AudioClip _dust;
    [SerializeField] private AudioClip _analyze;
    [SerializeField] private AudioClip _inspect;

    private AudioSource _audiosource;
    private void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        _audiosource.PlayOneShot(_click);
    }
    public void PlayDust()
    {
        _audiosource.PlayOneShot(_dust);
    }
    public void PlayAnalyze()
    {
        _audiosource.PlayOneShot(_analyze);
    }
    public void PlayInspect()
    {
        _audiosource.PlayOneShot(_inspect);
    }
}
