using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver: MonoBehaviour
{
    public void LoadScenes(string cena)
    {
        string nomeCenaCaverna = "CavernaScene"; 
        SceneManager.LoadScene(nomeCenaCaverna);
    }

    public void Quit()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
