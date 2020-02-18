using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public LayerMask touchInputMask;
    private List<GameObject> touchList = new List<GameObject>();
    private GameObject[] oldTouches;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButton(0)||Input.GetMouseButtonDown(0)||Input.GetMouseButtonUp(0))
	{
        oldTouches = new GameObject[touchList.Count];
        touchList.CopyTo(oldTouches);
        touchList.Clear();
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, touchInputMask))
            {
                GameObject recipient = hit.transform.gameObject;
                touchList.Add(recipient);
                if (Input.GetMouseButtonDown(0))
                {
                    recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                    Debug.Log("it works");
                }
                if (Input.GetMouseButton(0))
                {
                    recipient.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                }
                if (Input.GetMouseButtonUp(0))
                {
                    recipient.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                }
                

            }
            foreach (GameObject recipient in oldTouches)
            {
                if (!touchList.Contains(recipient))
                {

                    recipient.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);

                }
            }
        }

#endif
        #region Touch Input
        if(Input.touchCount > 0)
        {
            oldTouches = new GameObject[touchList.Count];
            //add the values over
            touchList.CopyTo(oldTouches);
            //reset the list
            touchList.Clear();
            foreach (Touch touch in Input.touches)
            {
                //send a ray forward from the touch point
                Ray ray = GetComponent<Camera>().ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit, touchInputMask))
                {
                    GameObject recipient = hit.transform.gameObject;
                    touchList.Add(recipient);
                    if(touch.phase == TouchPhase.Began)
                    {
                        recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Ended)
                    {
                        recipient.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Stationary)
                    {
                        recipient.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Canceled)
                    {
                        recipient.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                    }

                }
            }
            foreach  (GameObject recipient in oldTouches)
            {
                if (!touchList.Contains(recipient))
                {
                    
                        recipient.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                    
                }
            }
        }
        #endregion
    }
}
