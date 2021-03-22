using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera[] levels;
    public GameObject square;
    Camera currentCamera;

    // Start is called before the first frame update
    void Start()
    {

        currentCamera = levels[0];
        if(levels.Length > 1)
        {
            for (int i = 1; i<levels.Length; i++)
            {
                levels[i].enabled = false;
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("quare.transform.position.x" + square.transform.position.x);
        Debug.Log("currentCamera.pixelRect.xMax" + currentCamera.rect.xMax);
        if(square.transform.position.x > currentCamera.rect.xMax)
        {
            Debug.Log("Square went too far!");
            currentCamera = levels[1];
            levels[0].enabled = false;
            levels[1].enabled = true;
        }
    }

    void SetCurrentCamera() {
        //levels[0].
    }

}
