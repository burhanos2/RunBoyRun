using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    Rigidbody2D _object;
    const float _walkspeed = 0.1f;
    private float _acceleration = 1.0f;
    private float Xpos;
    private float Ypos;
    private float Zpos;

    // Use this for initialization
    void Start () {
        _object = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_acceleration <= 10)
        { 
            _acceleration += 0.05f;
        }

        Xpos = transform.position.x;
        Ypos = transform.position.y;
        Zpos = transform.position.z;
        _object.transform.position = new Vector3(Xpos + (_walkspeed * _acceleration), Ypos, Zpos);
    }
}
