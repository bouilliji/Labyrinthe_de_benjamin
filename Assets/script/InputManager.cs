using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private CameraController cameraController;

    void Start()
    {
        
    }

    void Update()
    {
        playerController.mouvX = Input.GetAxis("Horizontal") * Time.deltaTime;
        playerController.mouvZ = Input.GetAxis("Vertical") * Time.deltaTime;
        playerController.rotationY = Input.GetAxis("Mouse X") * Time.deltaTime;
        cameraController.rotationX = -Input.GetAxis("Mouse Y") * Time.deltaTime;
    }
}
