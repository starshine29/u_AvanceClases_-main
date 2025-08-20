using System;
using Unity.VisualScripting;
using UnityEngine;

//stay fresh. its a me

public class interactions : MonoBehaviour
{
    [SerializeField] public bool key1 = false;
    [SerializeField] public bool key2 = false;
    public GameObject door;
    private Animator animatorDoor;

    private void Start()
    {
        animatorDoor = door.GetComponent<Animator>();
    }

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
            
            case "Door":
                Debug.Log("abri la puerta");
                animatorDoor.SetBool("Anim_Door", true);
                break;
            
            default:
                Debug.Log("anda a buscar las llaves");
                break;
        }
    }
}