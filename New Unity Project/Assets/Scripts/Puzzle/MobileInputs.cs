using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInputs : MonoBehaviour
{
    [Header("Accelerometer")]
    public float speed = 10;
    public bool tilt = true;
    [Header("Pinch Zoom")]
    public float perspectiveZoomSpeed = 0.5f;
    public float orthographicZoomSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        if (tilt)
        {
            float accel = speed * Time.deltaTime;
            Accelerometer(accel);
        }
        PinchZoom();
    }
    void PinchZoom()
    {
        if (Input.touchCount == 2)
        {
            //first touch input on the screen
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);
            //difference between current and previous positions (positive or negative value)
            Vector2 touchZeroPreviousPosition = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePreviousPosition = touchOne.position - touchOne.deltaPosition;
            //Magnitude difference betweeen the first touches on screen
            float previosTouchMagitude = (touchZeroPreviousPosition - touchOnePreviousPosition).magnitude;
            //Magnitude difference between the current touches on screen           
            float currentTouchMagnitude = (touchZero.position - touchOne.position).magnitude;
            //Magnitude difference between the 2
            float magnitudeDifference = previosTouchMagitude - currentTouchMagnitude;
            if (Camera.main.orthographic)
            {
                Camera.main.orthographicSize += magnitudeDifference * orthographicZoomSpeed;
                Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize, 0.1f);


            }
            else
            {
                Camera.main.fieldOfView += magnitudeDifference * perspectiveZoomSpeed;
                Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 0.1f, 180);
            }
        }
    }
    void Accelerometer(float accel)
    {
        transform.Translate(Input.acceleration.x * accel, 0,0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
