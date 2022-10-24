using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void CenaJogar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void creditos()
    {
        SceneManager.LoadScene("creditos");
    }
    public void FecharJogo()
    {

    }
}
