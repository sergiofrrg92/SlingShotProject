using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("ResetControllerOnMouseUp");
        square.transform.position = originalPos;
        square.GetComponent<Rigidbody2D>().gravityScale = 0;
        square.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
