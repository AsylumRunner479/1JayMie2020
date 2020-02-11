using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class Board : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    public bool hover;
    public Vector2 scr;
    private void OnGUI()
    {
        if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
        {
            scr.x = Screen.width / 16;
            scr.y = Screen.height / 9;
        }

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        hover = true;
        

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        
        hover = false;
        
    }
    
   
}
