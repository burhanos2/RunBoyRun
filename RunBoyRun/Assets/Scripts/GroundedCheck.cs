using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    // raycast grounded check to be put here (and delete the temp one in movement)
    [SerializeField]
    private LayerMask GroundMask;
    [SerializeField]
    private float CheckHeight;
    [SerializeField]
    private AudioSource _jumpSound;

	    void Start ()
    {

       
	    }
	
	void Update ()
    {
        if (Physics2D.Raycast(this.transform.position, -transform.up, CheckHeight, GroundMask))
        {
            if (WareHouse._grounded == false)
            {
                WareHouse._grounded = true;
                _jumpSound.Play();
            }
            
        }
        else
        {
            if (WareHouse._grounded == true)
            { 
                WareHouse._grounded = false;
            }
            
        }
    }
}