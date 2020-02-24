using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoShit : MonoBehaviour
{
    public ContestManager contest;
    public GameObject self;

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
        if (contest.first != null)
        {
            contest.first = self.name;
        }
        else
        {
            contest.second = self.name;
        }
        GetComponent<Renderer>().material.color = Color.blue;
    }
    void OnTouchExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
