using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

    [SerializeField] private Transform[] pontosDoCaminho;
    private int pontoAtual;
    public float velocidade;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    void Movimento()
    {
        transform.position = Vector2.MoveTowards(transform.position, pontosDoCaminho[pontoAtual].position, velocidade);

        if (pontoAtual == 0)
        {
        }
    }
}
