using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timerValue, spawnTime;
    public bool canSpawn;
    public GameObject prefabToSpawn;

    // Start is called before the first frame update
    void TimerFunction()
    {
        timerValue += Time.deltaTime;
        if (timerValue >= spawnTime)
        {
            canSpawn = true;
        }
        else
        {
            canSpawn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
