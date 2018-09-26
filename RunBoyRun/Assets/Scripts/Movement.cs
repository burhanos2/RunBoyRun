using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody2D player;
    public float _jumpspeed;
    public float AirtimeMax;
    float _airtime;

    bool grounded;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //player.transform.position(0, 20, 0);
//jump
        if (Input.GetKey(KeyCode.Space))
        {
            _airtime--;
            if(_airtime > 0) { player.AddForce(player.transform.up * _jumpspeed, ForceMode2D.Impulse); }
        }
        if(Input.GetKeyUp(KeyCode.Space))
        { _airtime = AirtimeMax; }
	}
}
