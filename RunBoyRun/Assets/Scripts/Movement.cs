using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody2D player;
    const float _jumpspeed = 0.5f;
    const float AirtimeMax = 10;
    private float _airtime = AirtimeMax;

    private float Xpos;
    private float Ypos;
    private float Zpos;

    void ReadPos(Rigidbody2D _obj)
    {
        Xpos = _obj.transform.position.x;
        Ypos = _obj.transform.position.y;
        Zpos = _obj.transform.position.z;
    }


    bool grounded;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        ReadPos(player);

        //jump
        //if (Input.GetKeyUp(WareHouse._jumpButton)||_airtime <= 0)
        //{
        //    player.AddForce(player.transform.up * -(_jumpspeed*1.5f),ForceMode2D.Impulse);
        //}

        if (Input.GetKey(WareHouse._jumpButton) && _airtime > 0)
        {
            _airtime--;
            player.transform.position = new Vector3(Xpos, Ypos + _jumpspeed, Zpos);
        }
        if(Input.GetKeyUp(WareHouse._jumpButton))
        {
            _airtime = AirtimeMax;
        }
	}
}
