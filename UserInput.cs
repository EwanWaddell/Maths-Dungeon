using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public GameObject Canvas;
    public InputField inputField;
    public GameObject HowToUseScreen;

    public void GetInput() {
        if(inputField.text == "yes")
        {
        HowToUseScreen.SetActive(false);
        Canvas.SetActive(true);
        }
        else
        {
        Debug.Log("OtherInput");
        }        
    }
}