using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergaminho : MonoBehaviour
{
    public GameObject pergaminho;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        pergaminho.gameObject.SetActive(false);
    }

    // Update is called once per frame
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
