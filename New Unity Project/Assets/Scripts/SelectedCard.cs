using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCard : MonoBehaviour
{
    public static GameObject selectedObject;

    // Update is called once per frame
    void Update()
    {
      if(selectedObject != null)
        {
            Debug.Log("Moving");
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            selectedObject.transform.position = pos;
            Debug.Log("Finish Moving");

        }
    }
}
