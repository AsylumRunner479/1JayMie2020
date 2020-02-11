using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    




    public Image background;
    public bool hover, select, board;
    public GameObject self;
    //public RectTransform Worldspace, ScreenUI;
    public Vector2 scr;
    
    public GameObject Downgrade;
    public LayerMask curHand, Battlefield;
    public Camera cam;
    public void Start()
    {
        Set();
        
    }
    public void Set()
    {
        background.color = Color.blue;

        //self.transform.SetParent(Worldspace.transform);
        board = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        //throw new System.NotImplementedExceptions
        //eventData.hovered.
        hover = true;
        background.color = Color.blue;



    }
    public void OnPointerExit(PointerEventData eventData)
    {

        //throw new System.NotImplementedExceptions();
        hover = false;
        background.color = Color.red;



    }

    private void OnGUI()
    {
        if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
        {
            scr.x = Screen.width / 16;
            scr.y = Screen.height / 9;
        }

    }
    
    public void Update()
    {





        if (board == false)
        {
            background.color = Color.blue;

           

        }
        if (board == true)
        {

            background.color = Color.red;
            
        }

        if (hover == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                select = true;
                {
                    Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                        switch (hit.collider.tag)
                        {
                            case "world":
                                board = true;



                                break;
                        }

                    else
                        Debug.Log("Bounce");
                    Debug.Log("Battle");
                    Instantiate(Downgrade);
                    Downgrade.transform.position = Input.mousePosition;

                    Destroy(self);
                    
                }

            }
            if (Input.GetMouseButtonUp(0))
            {
                select = false;

                Debug.Log("Place");
                //RaycastHit hit;






            }
        }
        if (hover == false)
        {

        }
        if (select == true)
        {
            Vector3 pos = Input.mousePosition;

            self.transform.position = pos;
        }
    }

}

