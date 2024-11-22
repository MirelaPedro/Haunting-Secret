using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergaminho : MonoBehaviour
{
    public GameObject mensagem;

    void Start()
    {
        if (mensagem == null)
        {
            mensagem = GameObject.FindWithTag("Item"); 
        }

        mensagem.SetActive(false);
    }

    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensagem.SetActive(true);
        }
    }
}
