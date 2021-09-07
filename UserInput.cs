using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public GameObject Canvas;
    public InputField inputField;
    public GameObject HaveYouUsedScreen;
    public GameObject HowToUseScreen;

    public void GetInput() { //This method is about looking at what the user inputs and reacting appropriately
        if(inputField.text == "yes" || inputField.text == "Yes" || inputField.text == "YES" || inputField.text == "yES" || inputField.text == "YEs" || inputField.text == "YeS" || inputField.text == "yEs" || inputField.text == "yeS")
        {
        HaveYouUsedScreen.SetActive(false);
        Canvas.SetActive(true);
         //This makes it so that when you put in any variation of capital letters with "Yes" it will respond by bringing up the appropriate screen
        }
        if(inputField.text == "no" || inputField.text == "NO" || inputField.text == "No" || inputField.text == "nO")
        {
            HaveYouUsedScreen.SetActive(false);
            HowToUseScreen.SetActive(true);
            //This makes it so that when you put in any variation of capital letters with "No" it will respond by bringing up the appropriate screen
        }
        else
        {
        inputField.text = "Please put Yes or No"; //This makes it so that if you input an incorrect word it will tell you to put in "Yes" or "No"
        }        

    }
}