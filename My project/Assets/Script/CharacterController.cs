using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpforce = 250f;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private bool grounded;
    private bool started;
    private bool jumping;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); //caching
        _animator = GetComponent<Animator>();
        grounded = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
            {

            if (started && grounded)
            {
                _animator.SetTrigger("Jump");
                grounded = false;
                jumping = true;
            }
            else
            {
                _animator.SetBool("GameStarted", true);
                started = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if (started) 
        {
            _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);
        }
        if (jumping)
        {
            Debug.Log(jumping);
            _rigidbody2D.AddForce(new Vector2(0f, jumpforce));
            jumping = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
