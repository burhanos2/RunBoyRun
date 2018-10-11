using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody2D player;
    const float _jumpspeed = 10f;
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


        //if (Input.GetKeyUp(WareHouse._jumpButton) )
        //{
        //    player.AddForce(-player.transform.up *, ForceMode2D.Impulse);
        //}

        if (Input.GetKeyDown(WareHouse._jumpButton)  && WareHouse._grounded == true)
        {
            //_airtime--;
            player.AddForce(player.transform.up * _jumpspeed, ForceMode2D.Impulse);
            if (WareHouse._grounded == true)
            {
                WareHouse._grounded = false;
            }
        }

        //if (Input.GetKeyUp(WareHouse._jumpButton))
        //{
        //    _airtime = AirtimeMax;
        //}

       
    }

    //temp
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            if (WareHouse._grounded == false)
            {
                WareHouse._grounded = true;
            }

        }
    }

}
