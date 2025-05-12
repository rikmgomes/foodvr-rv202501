using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBUTTON : MonoBehaviour
{
    public GameObject tela;

    public void AbrirTela()
    {
        tela.SetActive(!tela.activeSelf);
    }
}
