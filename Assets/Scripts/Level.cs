using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public GameObject leftLevel;
    public GameObject rightLevel;
    public GameObject topLevel;
    public GameObject bottomLevel;

    bool HasLeftLevel() => leftLevel != null;
    bool HasRightLevel() => rightLevel != null;
    bool HasTopLevel() => topLevel != null;
    bool HasBottomLevel() => bottomLevel != null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
