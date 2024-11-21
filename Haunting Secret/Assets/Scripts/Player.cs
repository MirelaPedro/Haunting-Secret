using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    public float speed = 5;
    public float jump = 500;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping = false;

    private SpriteRenderer sprite;

    Animator anim;

    private int life = 1;

    private bool dead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        anim = GetComponent<Animator>();
    }

    // Update is called once per fram
    void Update()
    {
        if (!dead) { 
            Move = Input.GetAxis("Horizontal");

            if (Move != 0)
            {
                Flip(Move);
            }

            rb.velocity = new Vector2(speed * Move, rb.velocity.y);

            if (Input.GetButtonDown("Jump") && !isJumping)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jump));
            }

            Animations();
        }
        else
        {
            anim.SetInteger("transitions", 0);
        }
    }

    private void OnSceneLoaded(Scene cena, LoadSceneMode loadSceneMode)
    {
        GameObject spawnposicao = GameObject.FindGameObjectWithTag("SpawnFase2");
        Transform posicaoinicial = spawnposicao.transform;
        Vector3 pos = posicaoinicial.position;
        this.transform.position = pos;
    } 

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }

        if (other.gameObject.tag == "ataque")
        {
            life--;
            if (life < 1)
            {
                dead = true;
            }
        }
}

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }

    private void Flip(float Move)
    {
        if (Move > 0)
        {
            sprite.flipX = false; 
        }
        else if (Move < 0)
        {
            sprite.flipX = true;  
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("Item pego!");

            Destroy(other.gameObject);
        }
    }

    private void Animations()
    {
        if (isJumping)
        {
            anim.SetInteger("transitions", 3); 
        }
        else if (Move != 0) 
        {
            anim.SetInteger("transitions", 4); 
        }
        else 
        {
            anim.SetInteger("transitions", 2); 
        }
    }



}




