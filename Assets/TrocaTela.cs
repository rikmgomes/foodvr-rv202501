using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaTela : MonoBehaviour
{
    public void Hamburguer()
    {
        SceneManager.LoadScene("Foodv1");
    }
    public void Pizza()
    {
        SceneManager.LoadScene("Foodv1 1");
    }
    public void Sushi()
    {
        SceneManager.LoadScene("Foodv1 2");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("HUB MAIN");
    }
}
