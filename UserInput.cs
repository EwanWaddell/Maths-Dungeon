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

    public void GetInput() {
        if(inputField.text == "yes" || inputField.text == "Yes" || inputField.text == "YES" || inputField.text == "yES" || inputField.text == "YEs" || inputField.text == "YeS" || inputField.text == "yEs" || inputField.text == "yeS")
        {
        HaveYouUsedScreen.SetActive(false);
        Canvas.SetActive(true);
        }
        if(inputField.text == "no" || inputField.text == "NO" || inputField.text == "No" || inputField.text == "nO")
        {
            HaveYouUsedScreen.SetActive(false);
            HowToUseScreen.SetActive(true);
        }
        else
        {
        inputField.text = "Please put Yes or No";
        }        
    }
}