using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptObjetos : MonoBehaviour
{
    public GameObject[] objetosPrefab; 
    public Transform[] spawners; 
    public float delay = 2.0f;
    public float delayDeCambio = 5.0f; 
    public static int cantidad;

    void Start()
    {
        cantidad = Random.Range(4, 20);
        int elemento = Random.Range(0, 20);
        StartCoroutine(SpawnObjects(cantidad, elemento)); 
    }

    IEnumerator SpawnObjects(int cantidad, int elemento) 
    {
        for (int i = 0; i < cantidad; i++)
        {
            int spawnerIndex = Random.Range(0, spawners.Length);
            Instantiate(objetosPrefab[elemento], spawners[spawnerIndex].position, spawners[spawnerIndex].rotation);
            yield return new WaitForSeconds(delay);
        }

        yield return new WaitForSeconds(delayDeCambio);
        SceneManager.LoadScene("UI");
    }

    void Update()
    {

    }
}
