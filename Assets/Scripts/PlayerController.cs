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
        if (Input.GetMouseButtonDown(0))
        {
            PushPlayer();
        }
    }

    private Vector3 getMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 screenToWorldPoint = Camera.main.ScreenToWorldPoint(mousePos);
        screenToWorldPoint.z = 0;
        return screenToWorldPoint;
    }

    private void PushPlayer()
    {
        Vector3 mousePosition = getMouseWorldPosition();
        Debug.Log("Mouse Position: " + mousePosition);
        Vector3 pushVector = Vector3.Normalize(new Vector3(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y));
        if(pushVector.y < 0)
        {
            pushVector.y *= -1;
        }
        if(body.gravityScale != 1f)
        {
            body.gravityScale = 1f;
        }
        
        body.AddRelativeForce(pushVector * forceImpulse, ForceMode2D.Impulse);
    }


}
