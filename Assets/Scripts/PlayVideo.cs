using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{

    [SerializeField] private int maxDistance = 100;

    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            string nameOfRaycastHit = Raycast();
            if (nameOfRaycastHit.Equals("Pause Button"))
            {
                Debug.Log("Pausing the video");
            }
            if (nameOfRaycastHit.Equals("Stop Button"))
            {
                Debug.Log("Stopping the video");
            }
            if (nameOfRaycastHit.Equals("Start Button"))
            {
                Debug.Log("Starting the video");
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
}
