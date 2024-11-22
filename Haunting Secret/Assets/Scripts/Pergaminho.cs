using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergaminho : MonoBehaviour
{
    public GameObject mensagem;

    
    void Start()
    {
        mensagem.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensagem.gameObject.SetActive(true);
        }
    }
}
