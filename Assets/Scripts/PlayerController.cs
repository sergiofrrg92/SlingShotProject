using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D body;
    Vector3 originalPosition;

    public float maxDistance;
    public float forceImpulse;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        originalPosition = transform.position;

    }
    // Update is called once per frame
        void Update()
    {
        
    }

    private Vector3 getMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 screenToWorldPoint = Camera.main.ScreenToWorldPoint(mousePos);
        screenToWorldPoint.z = 0;
        return screenToWorldPoint;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = getMouseWorldPosition();
        Debug.Log("Mouse Position: " + mousePosition);
        Debug.Log("OriginalPos: " + originalPosition);
        float distance = Vector3.Distance(mousePosition, originalPosition);

        transform.position = Vector3.MoveTowards(originalPosition, mousePosition, maxDistance);

        Debug.Log("Distance: " + distance);
        Debug.Log("--------------");
        

    }

    private void OnMouseUp()
    {
        Vector3 force = originalPosition;
        //transform.position = Vector3.MoveTowards(transform.position, originalPosition, maxDistance);
        body.gravityScale = 1f;
        body.AddRelativeForce(new Vector2(originalPosition.x - transform.position.x, originalPosition.y - transform.position.y) * forceImpulse, ForceMode2D.Impulse);

    }

    
}
