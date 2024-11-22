using UnityEngine;
using UnityEngine.UI;

public class FecharPapel : MonoBehaviour
{
    public GameObject Pergaminho;  

    void Start()
    {
        
        
    }

    
    public void Fechar()
    {
        Pergaminho.SetActive(false); 
    }
}
