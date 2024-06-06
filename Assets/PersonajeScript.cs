using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
public int Hambre;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void TomarAlimento(int ValorAlimentario)
    {
        Hambre -= ValorAlimentario;
        if (Hambre < 0)
        {
            Hambre = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        AlimentosScript alimentos;
        alimentos = other.GetComponent<AlimentosScript>();
        if (alimentos)
        {
            TomarAlimento(alimentos.ValorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
