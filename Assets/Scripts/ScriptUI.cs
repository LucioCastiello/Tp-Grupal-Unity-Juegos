using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BOTONES : MonoBehaviour
{
    public GameObject txt1;
    public GameObject txt2;
    public InputField inputField;
    public GameObject titulo;
    public GameObject escribirunnumero;
    public GameObject panelError;
    public GameObject cantidadnro;


    void Start()
    {
        escribirunnumero.SetActive(false);
        panelError.SetActive(false);
    }

    public void Mostrar()
    {
        string inputText = inputField.text;

        if (int.TryParse(inputText, out int result))
        {
            titulo.SetActive(false);
            cantidadnro.SetActive(false);
            escribirunnumero.SetActive(true);
            panelError.SetActive(false);

            if (Convert.ToInt32(inputText) == ScriptObjetos.cantidad)
            {
                txt2.SetActive(false);
            }
            else
            {
                txt1.SetActive(false);
            }
        }
        else
        {
            titulo.SetActive(false);
            cantidadnro.SetActive(false);
            escribirunnumero.SetActive(false);
            panelError.SetActive(true);
        }
    }

    public void Ok()
    {
        titulo.SetActive(true);
        cantidadnro.SetActive(true);
        escribirunnumero.SetActive(false);
        panelError.SetActive(false);
    }

    public void ReRun()
    {
        SceneManager.LoadScene("CaenObjetos");
    }
}
