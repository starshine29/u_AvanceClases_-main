using System;
using Unity.VisualScripting;
using UnityEngine;

//stay fresh. its a me

public class interactions : MonoBehaviour
{
    public bool key1 = false;

    [SerializeField]
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("NPC"))
        {
            Debug.Log("Toma la llave");
            key1 = true;
        }
    }
}