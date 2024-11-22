using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManger : MonoBehaviour
{
    public void LoadScenes(string cena)
    {
        string jogarnovamente = "CavernaScene";
        SceneManager.LoadScene(jogarnovamente);
    }

    public void Quit()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}

