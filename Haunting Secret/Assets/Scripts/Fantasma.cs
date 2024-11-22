using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fantasma : MonoBehaviour
{
    Animator anim;
    private float speed = 2;
    public bool ground = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool facingRight = true;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        ground = Physics2D.Linecast(groundCheck.position, transform.position, groundLayer);

        if(ground == false)
        {
            speed *= -1;
        }

        if(speed > 0 && !facingRight)
        {
            Flip();
            anim.SetInteger("transit", 0);
        }

        else if(speed < 0 && facingRight)
        {
            Flip();
            anim.SetInteger("transit", 0);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
