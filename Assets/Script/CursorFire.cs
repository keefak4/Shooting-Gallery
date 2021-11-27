using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFire : MonoBehaviour
{
    private Camera cameraCursor;
    private void Start()
    {
        cameraCursor = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnGUI()
    {
        int size = 24;
        float posX = cameraCursor.pixelWidth / 2 - size / 4;
        float posY = cameraCursor.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
