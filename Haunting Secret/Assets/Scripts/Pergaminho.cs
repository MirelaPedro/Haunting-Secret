using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergaminho : MonoBehaviour
{
    public Image backpergaminho;

    // Start is called before the first frame update
    void Start()
    {
        backpergaminho.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            backpergaminho.gameObject.SetActive(true);
        }
    }
}
