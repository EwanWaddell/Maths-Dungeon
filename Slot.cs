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

    public void SelectSlot() { 
        if (transform.childCount > 0) 
        {
            manager.currentSlot = ID; //This makes it so that when you click a slot it becomes selected
        }
    }
}    