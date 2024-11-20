using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

    [SerializeField] private Transform[] pontosDoCaminho;
    private int pontoAtual;
    public float velocidade;
    private float positionX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Espelhar();
    }

    void Movimento()
    {
        transform.position = Vector2.MoveTowards(transform.position, pontosDoCaminho[pontoAtual].position, velocidade *Time.deltaTime);

        if (transform.position == pontosDoCaminho[pontoAtual].position)
        {
            pontoAtual += 1;
            positionX = transform.localPosition.x;

            if (pontoAtual >= pontosDoCaminho.Length) { 
                pontoAtual = 0;
            }
        }
    }

    void Espelhar()
    {
        if (transform.localPosition.x < positionX)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (transform.localPosition.x > positionX)
        {
            transform.localScale = new Vector3( 1f, 1f, 1f);
        }
    }

}
