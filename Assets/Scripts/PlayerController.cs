using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D body;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        playerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 getMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = getMouseWorldPosition();
        Debug.Log("Mouse Position: " + mousePosition);
        Debug.Log("PlayerPos: " + playerPosition);
        float distance = Vector3.Distance(mousePosition, playerPosition);
        Debug.Log("Distance: " + distance);
        Debug.Log("--------------");
        

    }

    private void OnMouseUp()
    {
        
    }
}
