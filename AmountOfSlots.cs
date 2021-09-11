using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmountOfSlots : MonoBehaviour
{
    public InputField AmountSlotsInput;
    public GameObject Canvas;
    public GameObject HowManySlotsScreen;
    public string LinesOfSlots;
    public int Number;
    public GameObject Slot10;
    public GameObject Slot11;
    public GameObject Slot12;
    public GameObject Slot13;
    public GameObject Slot14;

    public void AskSlots() 
    {
        LinesOfSlots = AmountSlotsInput.text;
        if(AmountSlotsInput.text == "2")
        {
            Canvas.SetActive(true);
            HowManySlotsScreen.SetActive(false);
            Slot10.SetActive(false);
            Slot11.SetActive(false);
            Slot12.SetActive(false);
            Slot13.SetActive(false);
            Slot14.SetActive(false);
        }
        else if(AmountSlotsInput.text == "3")
        {
            Canvas.SetActive(true);
            HowManySlotsScreen.SetActive(false);
        }
        else{
        AmountSlotsInput.text = "Please put in a whole number between 2 and 3";
        }
    }
}