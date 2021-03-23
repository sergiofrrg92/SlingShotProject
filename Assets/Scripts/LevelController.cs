using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public Level[] levels;
    public GameObject square;
    Level currentLevel;

    // Start is called before the first frame update
    void Start()
    {

        currentLevel = levels[0];
        if(levels.Length > 1)
        {
            for (int i = 1; i<levels.Length; i++)
            {
                //(Camera)levels[i].transform.Find("Camera").gameObject.enable = false;
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    void SetCurrentCamera() {
        //levels[0].
    }

}
