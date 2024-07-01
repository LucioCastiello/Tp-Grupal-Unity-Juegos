using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptUI : MonoBehaviour
{
    public InputField inputField;
    public GameObject txtacertaste;
    public GameObject txtreintentar;
    public GameObject responder;
    public GameObject cantidadT;
    public GameObject paneldespues;
    public GameObject panelnada;
    public GameObject titulo;

    void Start()
    {
        paneldespues.SetActive(false);
        panelnada.SetActive(false);
    }

    public void Mostrar()
    {
        string inputText = inputField.text;

        if (int.TryParse(inputText, out int result))
        {
            titulo.SetActive(false);
            responder.SetActive(false);
            cantidadT.SetActive(false);
            paneldespues.SetActive(true);
            panelnada.SetActive(false);

            if (Convert.ToInt32(inputText) == ScriptObjetos.cantidad)
            {
                txtreintentar.SetActive(false);
            }
            else
            {
                txtacertaste.SetActive(false);
            }
        }
        else
        {
            titulo.SetActive(false);
            responder.SetActive(false);
            cantidadT.SetActive(false);
            paneldespues.SetActive(false);
            panelnada.SetActive(true);
        }
    }

    public void Ok()
    {
        titulo.SetActive(true);
        responder.SetActive(true);
        cantidadT.SetActive(true);
        paneldespues.SetActive(false);
        panelnada.SetActive(false);
    }

    public void ReRun()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
