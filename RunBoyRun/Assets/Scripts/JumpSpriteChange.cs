using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpriteChange : MonoBehaviour {
    Animator Runanim;
    // Use this for initialization
    void Start () {
        Runanim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Runanim.SetBool("Grounded", WareHouse._grounded);
    }
}
