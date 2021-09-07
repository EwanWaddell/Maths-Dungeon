using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class AddItem : MonoBehaviour
{
    public Transform[] slots;
    public bool[] isFull;
    public GameObject Item;
    public Color selectedColor;
    public Color unselectedColor;
    public int currentSlot;
 
    void Start(){ 
        slots = new Transform[transform.childCount];
        isFull = new bool[slots.Length];
        FindSlots();
    }
 
    void Update() {
        CheckFull(); //This makes a loop that looks at slots and if the slot is full and selected it will become highlighted
          for(int i = 0; i < slots.Length; i++) {
            if(slots[i].GetComponent<Slot>().ID == currentSlot && slots[i].childCount > 0) {
                slots[i].GetComponent<Image>().color = selectedColor;
            }
            else {
                slots[i].GetComponent<Image>().color = unselectedColor;
            }
        }
    }
 
    public void FindSlots(){
        for(int i = 0; i < transform.childCount; i++) {
            slots[i] = transform.GetChild(i);
            slots[i].GetComponent<Slot>().ID = i;
 
        }
    }
 
    public void CheckFull() {
        for(int i = 0; i < slots.Length; i++) { //This makes a loop that cycles through all slots and if they have an item in them, isFull is set to true, if there is no item isFull is set to false
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
        for (int i = 0; i < isFull.Length; i++) //This creates a loop that goes until it reaches the last slot unless it is caused to break first
        {
            if(isFull[i] == false) {
                GameObject current = Instantiate(Item, slots[i]);
                break; //This makes the program add an item to the first available slot when you click the add item button
            }
        }
    }
    public void DeleteItems() 
    {
         if(slots[currentSlot].childCount > 0  ) {
          Destroy(slots[currentSlot].GetChild(0).gameObject);
        //This makes it so that if the selected slot has an object in it, it will be deleted
         }
    }
}