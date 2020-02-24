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
            if (second + 1 == first || second - 2 == first)
            {
                Debug.Log("second wins");
            }
            else
            {
                Debug.Log("first wins");
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
