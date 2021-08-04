using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    public Transform[] slots;
    public bool[] isFull;
    public GameObject Item;

    public int currentSlot;

    void Start(){ 
        slots = new Transform[transform.childCount];
        isFull = new bool[slots.Length];
        FindSlots();
    }

    void Update() {
        CheckFull();
    }

    public void FindSlots(){
        for(int i = 0; i < transform.childCount; i++) {
            slots[i] = transform.GetChild(i);
            slots[i].GetComponent<Slot>().ID = i;

        }
    }

    public void CheckFull() {
        for(int i = 0; i < slots.Length; i++) {
            if(slots[i].childCount > 0)
            {
                isFull[i] = true;
            }
            else 
            {
                isFull[i] = false;
            }
        }
    }
    public void AddItemToSlot() {
        for (int i = 0; i < isFull.Length; i++) 
        {
            if(isFull[i] == false) {
                GameObject current = Instantiate(Item, slots[i]);
                break;
            }
        }
    }
    public void DeleteItems() 
    {
          Destroy(slots[currentSlot].GetChild(0).gameObject);
    }
}