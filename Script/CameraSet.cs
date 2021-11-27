using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSet : MonoBehaviour
{
    [SerializeField]private enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }
    [SerializeField] private RotationAxes axes = RotationAxes.MouseXandY;
    [SerializeField] private float sensitivityHor = 9.0f; 
    [SerializeField] private float sensitivityVert = 9.0f; 
    [SerializeField] private float mimimumVert = -45.0f;
    [SerializeField] private float maxmumVert = 45.0f;
    private float rotationX = 0;
    
    private void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }

        else
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            rotationX = Mathf.Clamp(rotationX, mimimumVert, maxmumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor; 
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
 
}
