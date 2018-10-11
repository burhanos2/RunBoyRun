using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouse : MonoBehaviour {
    public static KeyCode _jumpButton = KeyCode.Space;
    public static bool _grounded = false;

    // if needed to be copied
    /*     
          void ReadPos(Rigidbody2D _obj)
           {
              Xpos = _obj.transform.position.x;
              Ypos = _obj.transform.position.y;
              Zpos = _obj.transform.position.z;
           }
   */


    public static void makeFalse(bool variable)
    {
        if (WareHouse._grounded == true)
        {
            variable = false;
        }
    }

    public static void makeTrue(bool variable)
    {
        if (WareHouse._grounded == false)
        {
            variable = true;
        }
    }

}
