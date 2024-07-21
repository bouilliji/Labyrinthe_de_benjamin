using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraleClass
{

    public class Player
    {
        public string name {  get; set; }
        public float playerSpeed {set;get;}
        public int playerTeam { set; get; }
        public int Ysencibility {set;get;}

        public Player(int team, string name)
        {
            this.playerSpeed = 3.3f;
            this.playerTeam = team;
            this.Ysencibility = 500;
            this.name = name;
        }

    }

    public class CameraClass
    {

        public int Xsencibility { get; set;}

        public CameraClass()
        {
            Xsencibility = 500;
        }
    }

}
