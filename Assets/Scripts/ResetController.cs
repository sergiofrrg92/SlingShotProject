using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetController : MonoBehaviour
{
    public GameObject square;
    Vector3 originalPos;
    void Start()
    {
        originalPos = square.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
       
        SceneManager.LoadScene("SampleScene");
    }
}
