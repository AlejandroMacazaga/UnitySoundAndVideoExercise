using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource[]))]
public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip[] audioClipList;
    [SerializeField] private int currentAudio;
    private AudioSource _source;

    void Start()
    {
        _source = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_source.isPlaying)
            {
                _source.Stop();
            }

            AddRandomClipToSource();
            _source.loop = true;
            _source.Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (_source.isPlaying)
            {
                _source.Pause();
            }
            else
            {
                _source.Play();
            }
            
        }

        if (Input.GetMouseButtonDown(2))
        {
            if (_source.isPlaying)
            {
                _source.Stop();
            }
        }
    }

    private void AddRandomClipToSource()
    {
        currentAudio = Random.Range(0, audioClipList.Length);
        _source.clip = audioClipList[currentAudio];
    }
}
