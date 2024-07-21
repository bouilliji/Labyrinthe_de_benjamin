using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static GeneraleClass;

public class PlayerController : MonoBehaviour
{
    public Player playerOne = new Player(1, "benjamin");
    public float mouvX;
    public float mouvZ;
    public float rotationY;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(mouvX * playerOne.playerSpeed , 0 , mouvZ * playerOne.playerSpeed);
        transform.Rotate(0, rotationY * playerOne.Ysencibility, 0);
    }
}
