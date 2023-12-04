using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollide : MonoBehaviour
{

    private GameObject triggerNpc;
    private bool triggering;
    void Start()
    {
        
    }

    void Update()
    {
        if(triggering)
        {
            print("Player is triggering with " +  triggerNpc);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPCPong")
        {
            triggering = true;
            triggerNpc = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPCPong")
        {
            triggering = false;
            triggerNpc = null;
        }
    }
}
