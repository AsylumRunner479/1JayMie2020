using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoShit : MonoBehaviour
{
    
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
        GetComponent<Renderer>().material.color = Color.blue;
    }
    void OnTouchExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
