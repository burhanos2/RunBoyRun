﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouse : MonoBehaviour {
    public static KeyCode _jumpButton = KeyCode.Space;
    public static KeyCode _dropButton = KeyCode.X;
    public static bool _grounded = false;
    public static float _jumpspeed = 8.8f;
    public static bool dead = false;

    //time score
    public static float timeS = 0;

    //new score
    public static bool newscore;

    // if needed to be copied
    /*     
          void ReadPos(Rigidbody2D _obj)
           {
              Xpos = _obj.transform.position.x;
              Ypos = _obj.transform.position.y;
              Zpos = _obj.transform.position.z;
           }
   */



}
