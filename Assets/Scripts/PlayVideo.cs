using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    [SerializeField] private int maxDistance = 100;
    [SerializeField] private int currentVideo;
    [SerializeField] private VideoClip[] videoSources;
    private VideoPlayer _video;
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _video = gameObject.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            string nameOfRaycastHit = Raycast();
            if (nameOfRaycastHit.Equals("Pause Button"))
            {
                if (_video.isPlaying)
                {
                    _video.Pause();
                }
                else
                {
                    _video.Play();
                }
            }
            if (nameOfRaycastHit.Equals("Stop Button"))
            {

                _video.Stop();
            }
            if (nameOfRaycastHit.Equals("Start Button"))
            {
                
                if (_video.isPlaying)
                {
                    _video.Stop();
                }

                AddRandomVideoToSource();
                _video.Play();
            }
        }
    }

    private string Raycast()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            return hit.transform.name;
        }

        return "Bust";
    }
    
    private void AddRandomVideoToSource()
    {
        currentVideo = Random.Range(0, videoSources.Length);
        _video.clip =  videoSources[currentVideo];
    }
}
