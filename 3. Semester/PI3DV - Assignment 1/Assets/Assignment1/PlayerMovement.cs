using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _walkspeed = 30f;
    public float _runspeed = 60f;
    public float _jumpForce = 20f;
    private float _rotationspeed = 60f;

    public bool _alive = true;

    public Rigidbody _rb;

    void Start() 
    {
        _rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Update() 
    {
        if (!_alive) return;
        
        
    }
    void Move()
    {
        if (!_alive) return;

        if(Input.GetKey("w"))
        {
            // _rb.AddForce(0,0,_walkspeed);
            _rb.velocity = transform.forward * _walkspeed;
        }

        if(Input.GetKey("w") && Input.GetKey("left shift"))
        {
            _rb.AddForce(0,0,_runspeed);
        }

        if(Input.GetKey("a"))
        {
            transform.Rotate(0, -_rotationspeed*Time.deltaTime, 0);
            // _rb.AddForce(-_walkspeed,0,0);
        }

        if(Input.GetKey("d"))
        {
            transform.Rotate(0, _rotationspeed*Time.deltaTime, 0);
            // _rb.AddForce(_walkspeed,0,0);
        }
        
        if(Input.GetKey("s"))
        {
            _rb.velocity = -transform.forward * _walkspeed;

        }

        // NUMPADCONTROLS
        if(Input.GetKey("[8]"))
        {
            transform.Rotate( _rotationspeed*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("[5]") || Input.GetKey("[2]"))
        {
            
            transform.Rotate( -_rotationspeed*Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKey("[4]"))
        {
            // _rb.AddForce(-_rotationspeed,0,0);
            transform.Rotate(0, 0, _rotationspeed*Time.deltaTime);
        }

        if(Input.GetKey("[6]"))
        {
            // _rb.AddForce(_rotationspeed,0,0);
            transform.Rotate(0, 0, -_rotationspeed*Time.deltaTime);
        }
        
        if(Input.GetKey("w") && Input.GetKey(KeyCode.Space))
        {
            // _rb.AddForce(0,0,_walkspeed);
            _rb.velocity = transform.forward * _walkspeed + transform.up * _jumpForce;
        }

        if(Input.GetKey(KeyCode.Space))
            {
                // _rb.AddForce(0,0,_walkspeed);
                _rb.velocity = transform.up * _jumpForce;
            }
    }

}
