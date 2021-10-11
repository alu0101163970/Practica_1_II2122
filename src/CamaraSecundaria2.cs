using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSecundaria2 : MonoBehaviour
{
    public GameObject objeto; 
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        objeto = GameObject.FindWithTag("Camara secundaria 2");
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log($"Nombre del Objeto: {objeto.name}; Tag: {objeto.tag}; Contador del objeto: {contador++}"); 
    }
}
