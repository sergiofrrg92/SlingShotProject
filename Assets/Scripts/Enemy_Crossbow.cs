using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Crossbow : MonoBehaviour
{

    bool shoot = false;
    public float maxTimeToShoot = 3f;
    public float minTimeToShoot = 1f;
    float timeToShoot;
    float elapsedTime = 0;
    public GameObject bolt;
    // Start is called before the first frame update
    void Start()
    {
        timeToShoot = Random.Range(minTimeToShoot, maxTimeToShoot);
    }

    // Update is called once per frame
    void Update()
    {
        checkTime();
        if (shoot)
        {
            shoot = false;
            Object.Instantiate(bolt, transform.position, Quaternion.identity, transform);
        }
        
    }

    void checkTime()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeToShoot)
        {
            elapsedTime = 0;
            shoot = true;
        }
    }


}
