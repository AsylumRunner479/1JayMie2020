using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class CardBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
  
    public Image background;
    public bool hover, select, board;
    public GameObject self;
    public GameObject Worldspace, ScreenUI;
    public Transform world;
    public Vector2 scr;
    public HandSlot hand;
    public GameObject Upgrade;
    public LayerMask curHand, Battlefield;
    public Camera cam;
    public bool InZone;
    public Transform zone;
    public void Start()
    {
        background.color = Color.blue;
        world = Worldspace.transform;
        self.transform.SetParent(ScreenUI.transform);
        board = false;
        HoldCard();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        SelectedCard.selectedObject.GetComponent<CardDisplay>().baseUI.raycastTarget = true;
        //Place Card
        if (InZone)
        {
            Debug.Log("Battle");
            Instantiate(SelectedCard.selectedObject.gameObject.GetComponent<CardDisplay>().card.prefab, zone);
           // Upgrade = SelectedCard.selectedObject.gameObject;

            //Upgrade.transform.position = Input.mousePosition;

            //Upgrade.GetComponent<CardDisplay>().card = self.GetComponent<CardDisplay>().card;
            //Upgrade.GetComponent<CardDisplay>().baseUI = self.GetComponent<CardDisplay>().baseUI;
            //Upgrade.GetComponent<CardDisplay>().Worldspace = self.GetComponent<CardDisplay>().Worldspace;
            //Upgrade.transform.parent = world;
            //Upgrade.GetComponent<Upgrade>().Set();
            //Upgrade.GetComponent<Upgrade>().cam = cam;
            Destroy(SelectedCard.selectedObject);
            
        }
        else 
        {
        
        }
        SelectedCard.selectedObject = null;
    }
    public void OnPointerDown(PointerEventData eventData)
    {

        // Select Card
        SelectedCard.selectedObject = self.gameObject;
        SelectedCard.selectedObject.GetComponent<CardDisplay>().baseUI.raycastTarget = false;
        Debug.Log("Selected Card = " + SelectedCard.selectedObject.name);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
            //Highlight Card
            hover = true;
            background.color = Color.red;     
    }
    public void OnPointerExit(PointerEventData eventData)
    {
            //Stop Highlighting Card
            hover = false;
            background.color = Color.blue;  
    }
    
    private void OnGUI()
    {
        if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
        {
            scr.x = Screen.width / 16;
            scr.y = Screen.height / 9;
        }

    }
    public void HoldCard()
    {

        for (int i = 0; i < hand.cardSlot.Length; i++)
        {
            if (hand.cardSlot[i] == null)
            {
                self.transform.position = hand.cardSlot[i].position; //Vector3(cardSlot[i].x, cardSlot[i].position.y, cardSlot[i].position.z)
            }
            

        }
    }

   
    /*  public void Update()
 {

     PointerEventData mouse = new PointerEventData(EventSystem.current);
     mouse.position = Input.mousePosition;
     List<RaycastResult> findPA = new List<RaycastResult>();
     EventSystem.current.RaycastAll(mouse, findPA);
     int count = findPA.Count;



     if (board == false)
     {
         background.color = Color.blue;



     }
     if(board == true)
     {

         background.color = Color.red;

     }

     if (hover == true)
     {
         if (Input.GetMouseButtonDown(0))
         {
             select = true;
             {
                 Ray ray = cam.ViewportPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
                 RaycastHit hit;
                 if (Physics.Raycast(ray, out hit))
                     switch (hit.collider.tag)
                     {
                         case "world":

                             Debug.Log("Battle");
                             Instantiate(Upgrade.gameObject.GetComponent<CardDisplay>());
                             Upgrade.transform.position = Input.mousePosition;

                            Upgrade.GetComponent<CardDisplay>().card = self.GetComponent<CardDisplay>().card; 

                             Upgrade.transform.parent = world;
                             Upgrade.GetComponent<Upgrade>().Set();
                             Upgrade.GetComponent<Upgrade>().cam = cam;


                             break;
                         case "hand":
                             Debug.Log("Bounce");
                             board = false;
                             break;

                     }

                 else
                 {

                 }

             }

         }
         if (Input.GetMouseButtonUp(0))
         {
             select = false;

             Debug.Log("Place");
             //RaycastHit hit;
             Destroy(self);





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
 }*/

}
