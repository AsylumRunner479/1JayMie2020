using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContestManager : MonoBehaviour
{
    public int first, second;
    // Start is called before the first frame update
    public GameObject[] hands;

    public void Start()
    {
        first = 0;
        second = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if ( first != 0 && second != 0)
        {
            if (first == second)
            {
                Debug.Log("Draw");
            }
            if (first == 1)
            {
                if (second <= 8)
                            {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 2)
            {
                if (second <= 9 && second >= 2)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 3)
            {
                if (second <= 10 && second >= 3)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 4)
            {
                if (second <= 11 && second >= 4)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 5)
            {
                if (second <= 12 && second >= 5)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 6)
            {
                if (second <= 13 && second >= 6)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 7)
            {
                if (second <= 14 && second >= 7)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 8)
            {
                if (second <= 15 && second >= 8)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            if (first == 9)
            {
                if (second >= 9 && second >= 9)
                {
                    Debug.Log("second wins");
                }
                else
                {
                    Debug.Log("first wins");
                }
            }
            Debug.Log(first);
            Debug.Log(second);
            first = 0;
            second = 0;
        }  
        
        else
        {

        }
    }
}
