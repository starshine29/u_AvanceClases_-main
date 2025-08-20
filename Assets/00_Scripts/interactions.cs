using System;
using Unity.VisualScripting;
using UnityEngine;

//stay fresh. its a me

public class interactions : MonoBehaviour
{
    public bool key1 = false;
    public bool key2 = false;

    [SerializeField]
    private void OnTriggerEnter(Collider other) //entra en un trigger

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
}