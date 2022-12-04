using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 dragOffset;
    private Camera cam;

    private void Awake() {
        cam = Camera.main;
    }

    private void OnMouseDown() {
        dragOffset = transform.position - GetMousePosInWorld(); 
    }

    private void OnMouseDrag() {
        transform.position = GetMousePosInWorld() + dragOffset;
    }

    Vector3 GetMousePosInWorld() {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
