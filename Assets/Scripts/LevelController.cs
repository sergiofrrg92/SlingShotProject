using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public Level[] levels;
    public GameObject square;
    Level currentLevel;
    double currentViewPortX;
    double currentViewPortY;

    // Start is called before the first frame update
    void Start()
    {

        currentLevel = levels[0];
        currentViewPortX = System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).x);
        currentViewPortY = System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).y);
        if (levels.Length > 1)
        {
            for (int i = 1; i<levels.Length; i++)
            {
                levels[i].GetComponentInChildren<Camera>().enabled = false;
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Live pos X: " + System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).x));
        Debug.Log("Live pos Y: " + System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).y));
        //Debug.Log("Current: " + currentViewPortX);
        if((System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).x) == currentViewPortX + 1) && currentLevel.HasRightLevel())
        {
            Level previousLevel = currentLevel;
            currentLevel = currentLevel.rightLevel;
            currentLevel.GetComponentInChildren<Camera>().enabled = true;
            previousLevel.GetComponentInChildren<Camera>().enabled = false;

        }

        if ((System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).x) == currentViewPortX - 1) && currentLevel.HasLeftLevel())
        {
            Level previousLevel = currentLevel;
            currentLevel = currentLevel.leftLevel;
            currentLevel.GetComponentInChildren<Camera>().enabled = true;
            previousLevel.GetComponentInChildren<Camera>().enabled = false;

        }

        if ((System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).y) == currentViewPortY + 1) && currentLevel.HasTopLevel())
        {
            Level previousLevel = currentLevel;
            currentLevel = currentLevel.topLevel;
            currentLevel.GetComponentInChildren<Camera>().enabled = true;
            previousLevel.GetComponentInChildren<Camera>().enabled = false;

        }

        if ((System.Math.Floor(currentLevel.GetComponentInChildren<Camera>().WorldToViewportPoint(square.transform.position).y) == currentViewPortY - 1) && currentLevel.HasBottomLevel())
        {
            Level previousLevel = currentLevel;
            currentLevel = currentLevel.bottomLevel;
            currentLevel.GetComponentInChildren<Camera>().enabled = true;
            previousLevel.GetComponentInChildren<Camera>().enabled = false;

        }

    }

    void SetCurrentCamera() {
        //levels[0].
    }

}
