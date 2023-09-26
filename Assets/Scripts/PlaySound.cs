using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource[]))]
public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource[] audioDataList;
    [SerializeField] private int currentAudio;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (audioDataList[currentAudio].isPlaying)
            {
                audioDataList[currentAudio].Stop();
            }
            currentAudio = Random.Range(0, audioDataList.Length - 1);
            audioDataList[currentAudio].loop = true;
            audioDataList[currentAudio].Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (audioDataList[currentAudio].isPlaying)
            {
                audioDataList[currentAudio].Pause();
            }
            else
            {
                audioDataList[currentAudio].Play();
            }
            
        }

        if (Input.GetMouseButtonDown(2))
        {
            if (audioDataList[currentAudio].isPlaying)
            {
                audioDataList[currentAudio].Stop();
            }
        }
    }
}
