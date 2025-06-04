using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaTela : MonoBehaviour
{
    public void Hamburguer()
    {
        SceneManager.LoadScene("HUB MAIN 1");
    }
    public void Pizza()
    {
        SceneManager.LoadScene("HUB MAIN 3");
    }
    public void Sushi()
    {
        SceneManager.LoadScene("HUB MAIN 2");
    }
    public void ComidaSushi()
    {
        SceneManager.LoadScene("Foodv1 2");
    }
    public void ComidaPizza()
    {
        SceneManager.LoadScene("Foodv1 1");
    }
    public void ComidaHamburguer()
    {
        SceneManager.LoadScene("Foodv1");
    }
    public void TelaDeConfiguracoes()
    {
        SceneManager.LoadScene("HUB MAIN 4");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("HUB MAIN");
    }
}
