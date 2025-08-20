using System;
using Unity.VisualScripting;
using UnityEngine;

//stay fresh. its a me

public class interactions : MonoBehaviour
{
    [SerializeField] public bool key1 = false;
    [SerializeField] public bool key2 = false;


    /*private void OnTriggerEnter(Collider other) //entra en un trigger

    {
        if (other.CompareTag("NPC")) //si choca con un objeto de tag NPC
        {
            Debug.Log("Toma la llave"); //llave 1
            key1 = true;
        }

        if (other.CompareTag("NPC2"))
            {
             Debug.Log("Toma otra llave"); //llave 2
             key2 = true;
            }
    }
}*/

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "NPC":
                Debug.Log("tengo la llave 1");
                key1 = true;
                break;
            
            case "NPC2":
                Debug.Log("tengo otra llave");
                key2 = true;
                break;
            
            default:
                Debug.Log("anda a buscar las llaves");
                break;
        }
    }
}