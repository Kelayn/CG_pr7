using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCubeScript : MonoBehaviour
{

    private Vector3 MouseOffset;
    private float MouseZCoord;
    public GameObject GrabbedObject;

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(GrabbedObject.transform.position).z;

        MouseOffset = GrabbedObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = MouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + MouseOffset;
    }
}
