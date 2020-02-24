using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoShit : MonoBehaviour
{
    public ContestManager contest;
    public GameObject self;
    public int ID;

    void OnTouchDown()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    void OnTouchStay()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    void OnTouchUp()
    {
        if (contest.first == 0)
        {
            contest.first = ID;
        }
        else if (contest.second == 0)
        {
            contest.second = ID;
        }
        
        GetComponent<Renderer>().material.color = Color.blue;
    }
    void OnTouchExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
