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
        if(AmountSlotsInput.text == "2") //This makes it so that if the user inputs 2, the program accepts and changes screens, then makes the last line of slots disactive
        {
            Canvas.SetActive(true);
            HowManySlotsScreen.SetActive(false);
            Slot10.SetActive(false);
            Slot11.SetActive(false);
            Slot12.SetActive(false);
            Slot13.SetActive(false);
            Slot14.SetActive(false);
        }
        else if(AmountSlotsInput.text == "3") //This makes it so that if the user inputs 3, the program accepts and changes screens
        {
            Canvas.SetActive(true);
            HowManySlotsScreen.SetActive(false);
        }
        else{ //This makes it so that if any input other than 2 or 3 is put in it will come back as invalid and ask the user to try again
        AmountSlotsInput.text = "Please put in a whole number between 2 and 3";
        }
    }
}