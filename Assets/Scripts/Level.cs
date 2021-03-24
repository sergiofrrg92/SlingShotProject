using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public Level leftLevel;
    public Level rightLevel;
    public Level topLevel;
    public Level bottomLevel;

    public bool HasLeftLevel() => leftLevel != null;
    public bool HasRightLevel() => rightLevel != null;
    public bool HasTopLevel() => topLevel != null;
    public bool HasBottomLevel() => bottomLevel != null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static explicit operator Level(GameObject v)
    {
        throw new NotImplementedException();
    }
}
