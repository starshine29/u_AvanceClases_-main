using System;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    private bool key1 = false;

    [SerializeField] private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            {
                key1 = true;
            }
    }
}
