using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GeneraleClass;

public class CameraController : MonoBehaviour
{
    public CameraClass PlayerCamera = new CameraClass();

    public float rotationX;
    [SerializeField]
    private float rotationXClamp;

    void Update()
    {
        rotationXClamp = Mathf.Clamp((rotationX * PlayerCamera.Xsencibility) + transform.rotation.x , -90 , 75);
        transform.localRotation = Quaternion.Euler((rotationX * PlayerCamera.Xsencibility) - transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }
}
