using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int ID;
    public AddItem manager;

    void Start() {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<AddItem>();
    }

    public void SelectSlot()
    { 
        manager.currentSlot = ID;
    }
}    