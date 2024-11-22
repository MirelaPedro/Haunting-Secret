using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergaminho : MonoBehaviour
{
    public GameObject pergaminho;
    public GameObject player;

    
    void Start()
    {
        pergaminho.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pergaminho.gameObject.SetActive(true);
        }
    }
}
