using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    [SerializeField]
    private string ProximaFase;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IrProximaFase();
    }
    private void IrProximaFase()
    {
        SceneManager.LoadScene(this.ProximaFase);
    }
    
}
