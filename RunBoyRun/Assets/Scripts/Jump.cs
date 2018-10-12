using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
     Rigidbody2D player;
    private float _jumpspeed = WareHouse._jumpspeed;
    //const float AirtimeMax = 10;
   // private float _airtime = AirtimeMax;

    private float Xpos;
    private float Ypos;
    private float Zpos;

    void ReadPos(Rigidbody2D _obj)
    {
        Xpos = _obj.transform.position.x;
        Ypos = _obj.transform.position.y;
        Zpos = _obj.transform.position.z;
    }


	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ReadPos(player);

        //jump
        if (Input.GetKeyDown(WareHouse._jumpButton)  && WareHouse._grounded == true)
        {
            //_airtime--;
            player.AddForce(player.transform.up * _jumpspeed, ForceMode2D.Impulse);
            WareHouse._grounded = false;
           
        }


       
    }

 

}
