using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantDrop : MonoBehaviour {
    private float _jumpspeed = WareHouse._jumpspeed;
    Rigidbody2D player;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(WareHouse._dropButton))
        {
            player.AddForce(-player.transform.up * (_jumpspeed*2), ForceMode2D.Impulse);
        }
	}
}
