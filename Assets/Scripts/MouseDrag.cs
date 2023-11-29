using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    private Camera cam;
    public float sensitivity = 3f;

    void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDrag()
    {
        float distanceToScreen = cam.WorldToScreenPoint(transform.position).z;

        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToScreen));

        Debug.Log("MouseDrag Doesn't work");

    }

    // Scriptet nedan fungerar inte men påpekar heller inte att det är felskrivet... fortsätt klura..

   /* private void Update()
    {
        if (cam.orthographic)
        {
            float xAxisRotation = Input.GetAxis("Mouse ScrollWheel") * sensitivity;
            transform.Rotate(Vector3.down, xAxisRotation);
        }
        else
        {
            Debug.Log("Scroll Wheel Doesn't work");
        }
    }*/
}
