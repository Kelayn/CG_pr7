using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube5 : MonoBehaviour
{
    private Vector3 MouseOffset;
    private float MouseZCoord;

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffset = gameObject.transform.position - GetMousePosition();
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
